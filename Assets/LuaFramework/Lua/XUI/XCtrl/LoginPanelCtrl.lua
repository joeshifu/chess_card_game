require "Common/define"
require "Common/protocal"
require "Common/functions"
Event = require 'events'
require "3rd/pbc/protobuf"

local transform;
local gameObject;

LoginPanelCtrl = {};
local this = LoginPanelCtrl;

--构建函数--
function LoginPanelCtrl.New()
	--logWarn("LoginPanelCtrl.New--->>");
	return this;
end

function LoginPanelCtrl.Awake(xpage)
    --logWarn('LoginPanelCtrl Awake--->>>'..'xpage name:'..xpage.m_pageName);
    xpage.m_pageType = EPageType.Normal;
    xpage.m_pageMode = EPageMode.DoNothing;
end

function LoginPanelCtrl.Start()
    log('LoginPanelCtrl Start--->>>');
    Event.AddListener(Protocal.LoginResponse, this.OnLoginResponse); 
    EventTriggerListener.Get(LoginPanelView.loginBtn.gameObject):AddClick(LoginPanelView.loginBtn,this.OnLoginClick);
    EventTriggerListener.Get(LoginPanelView.registerBtn.gameObject):AddClick(LoginPanelView.registerBtn,this.OnRegisterBtnClick);
    EventTriggerListener.Get(LoginPanelView.weChatLoginBtn.gameObject):AddClick(LoginPanelView.weChatLoginBtn,this.OnWeChatLoginBtnClick);
end

function LoginPanelCtrl.Rest()
    log('LoginPanelCtrl Rest--->>>');
end

function LoginPanelCtrl.Hide()
    log('LoginPanelCtrl Hide--->>>');
end

function LoginPanelCtrl.Destroy()
    log('LoginPanelCtrl Destroy--->>>');
    Event.RemoveListener(Protocal.LoginResponse);
end
---------------------------------------------------------------------------------------
--登录按钮点击--
function LoginPanelCtrl.OnLoginClick(go)   
    this.SendLogin(LoginPanelView.userName.text,LoginPanelView.passWord.text);
end

--注册按钮点击--
function LoginPanelCtrl.OnRegisterBtnClick(go)
    log("registerBtn clicked.............")
end

--微信登录按钮点击--
function LoginPanelCtrl.OnWeChatLoginBtnClick(go)
    log("weChatLoginBtn clicked................")
end
----------------------------------------------------------------------------------------
--发送登陆--
function LoginPanelCtrl.SendLogin(_userName,_passWord)
    log(_userName.."|".._passWord);
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

--登陆返回--
function LoginPanelCtrl.OnLoginResponse(buffer)
    local data = buffer:ToLuaByteBuffer();
    local path = Util.DataPath.."lua/3rd/pbc/gt_base.pb";
    local addr = io.open(path, "rb")
    local buffer = addr:read "*a"
    addr:close()
    protobuf.register(buffer)
    local decode = protobuf.decode("gt_msg.LoginResponse",data)
    log('LoginPanelCtrl.OnLoginResponse--->>>'..decode.szDescribeString);

    --    
    --for _,v in ipairs(decode.phone) do
      --  print("\t"..v.number, v.type)
    --end
end

