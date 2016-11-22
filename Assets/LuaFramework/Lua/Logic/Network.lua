
require "Common/define"
require "Common/protocal"
require "Common/functions"
Event = require 'events'

require "3rd/pblua/login_pb"
require "3rd/pbc/protobuf"

local sproto = require "3rd/sproto/sproto"
local core = require "sproto.core"
local print_r = require "3rd/sproto/print_r"

Network = {};
local this = Network;

local transform;
local gameObject;


function Network.Start() 
    logWarn("Network.Start!!");
   
    Event.AddListener(Protocal.HHResponse, this.OnHHResponse); 
    Event.AddListener(Protocal.LoginResponse, this.OnLoginResponse); 
end

--Socket消息分发--
function Network.OnSocket(key, data)
    Event.Brocast(tostring(key), data);
end

--当连接建立时--
function Network.OnConnect() 
    logWarn("Game Server connected!!");

    --测试登陆
    this.TestSendLogon();

    --开定时器，发心跳包
    --this.SendHeart(); 

    --coroutine.start(this.test_coroutine);
end

function Network.OnConnectFailed()
     logWarn("connected failed !!");
end

--连接中断，或者被踢掉--
function Network.OnDisconnect() 
    logError("OnDisconnect------->>>>");
end
------------------------------------------------
function Network.TestSendLogon()
    local path = Util.DataPath.."lua/3rd/pbc/gt_base.pb";
    log('io.open--->>>'..path);

    local addr = io.open(path, "rb")
    local buffer = addr:read "*a"
    addr:close()
    protobuf.register(buffer)

    local _LoginRequest = {
        accounts = "joe2",
        password = "4297f44b13955235245b2497399d7a93",
        sessionid = "123456",
        uid = "10000",
        dwPlazaVersion = 101515267,
        szMachineID = "b1a6afedf9cbc767ac8ff04fe997655a",
        dwLogonType = 3,
        dwClientVersion = 5003,
        dwClientIP = "28551360",       
    }
    local code = protobuf.encode("gt_msg.LoginRequest", _LoginRequest)

    local buffer = ByteBuffer.New();
    buffer:WriteBuffer(code);
    networkMgr:SendMessage(Protocal.LoginRequest,buffer);
end

function Network.OnLoginResponse(buffer)
    local data = buffer:ToLuaByteBuffer();
    local path = Util.DataPath.."lua/3rd/pbc/gt_base.pb";
    local addr = io.open(path, "rb")
    local buffer = addr:read "*a"
    addr:close()
    protobuf.register(buffer)
    local decode = protobuf.decode("gt_msg.LoginResponse",data)
    log('Network.OnLoginResponse--->>>'..decode.szDescribeString);
end

function Network.SendHeart()
    local path = Util.DataPath.."lua/3rd/pbc/gt_base.pb";
    log('io.open--->>>'..path);

    local addr = io.open(path, "rb")
    local buffer = addr:read "*a"
    addr:close()
    protobuf.register(buffer)

    local hhrequest = {
       
    }
    local code = protobuf.encode("gt_msg.HHRequest", hhrequest)

    local buffer = ByteBuffer.New();
    buffer:WriteBuffer(code);
    networkMgr:SendMessage(Protocal.HHRequest,buffer);
end

function Network.OnHHResponse(buffer)
    local data = buffer:ToLuaByteBuffer();
    local path = Util.DataPath.."lua/3rd/pbc/gt_base.pb";
    local addr = io.open(path, "rb")
    local buffer = addr:read "*a"
    addr:close()
    protobuf.register(buffer)
    local decode = protobuf.decode("gt_msg.HHResponse" , data)
    print(decode.serverTimeNow)
end

--测试协同--
function Network.test_coroutine()    
    logWarn("1111");
    coroutine.wait(1);  
    logWarn("2222");
    
    local www = WWW("http://bbs.ulua.org/readme.txt");
    coroutine.www(www);
    logWarn(www.text);      
end
------------------------------------------------
--登录返回--
function Network.OnMessage(buffer) 
	if TestProtoType == ProtocalType.BINARY then
		this.TestLoginBinary(buffer);
	end
	if TestProtoType == ProtocalType.PB_LUA then
		this.TestLoginPblua(buffer);
	end
	if TestProtoType == ProtocalType.PBC then
		this.TestLoginPbc(buffer);
	end
	if TestProtoType == ProtocalType.SPROTO then
		this.TestLoginSproto(buffer);
	end
	----------------------------------------------------

    logWarn('OnMessage-------->>>');
end

--二进制登录--
function Network.TestLoginBinary(buffer)
	local protocal = buffer:ReadByte();
	local str = buffer:ReadString();
	log('TestLoginBinary: protocal:>'..protocal..' str:>'..str);
end

--PBLUA登录--
function Network.TestLoginPblua(buffer)
	local protocal = buffer:ReadByte();
	local data = buffer:ReadBuffer();

    local msg = login_pb.LoginResponse();
    msg:ParseFromString(data);
	log('TestLoginPblua: protocal:>'..protocal..' msg:>'..msg.id);
end

--PBC登录--
function Network.TestLoginPbc(buffer)
	local protocal = buffer:ReadByte();
	local data = buffer:ReadBuffer();

    local path = Util.DataPath.."lua/3rd/pbc/addressbook.pb";

    local addr = io.open(path, "rb")
    local buffer = addr:read "*a"
    addr:close()
    protobuf.register(buffer)
    local decode = protobuf.decode("tutorial.Person" , data)

    print(decode.name)
    print(decode.id)
    for _,v in ipairs(decode.phone) do
        print("\t"..v.number, v.type)
    end
	log('TestLoginPbc: protocal:>'..protocal);
end

--SPROTO登录--
function Network.TestLoginSproto(buffer)
	local protocal = buffer:ReadByte();
	local code = buffer:ReadBuffer();

    local sp = sproto.parse [[
    .Person {
        name 0 : string
        id 1 : integer
        email 2 : string

        .PhoneNumber {
            number 0 : string
            type 1 : integer
        }

        phone 3 : *PhoneNumber
    }

    .AddressBook {
        person 0 : *Person(id)
        others 1 : *Person
    }
    ]]
    local addr = sp:decode("AddressBook", code)
    print_r(addr)
	log('TestLoginSproto: protocal:>'..protocal);
end

--卸载网络监听--
function Network.Unload()
    --Event.RemoveListener(Protocal.Message);
    logWarn('Unload Network...');
end