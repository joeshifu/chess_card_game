public class GameMessages
{
    //心跳
    public const int MDM_GP_HEAT = 0;
    public const int SUB_MB_HEAT_BEAT = 1;


    public const int MB_VALIDATE_FLAGS = 0x01;                                //效验密保
    public const int LOW_VER_VALIDATE_FLAGS = 0x02;                                //效验低版本

    public const int SUB_GP_SNED_EFFICACY = 6;  //发送验证码
    public const int SUB_GP_LOCK_MOBILE = 7;  //验证码

    //TODO:登陆命令
    public const int MDM_GP_LOGON = 1;			//广场登陆

    //登陆模式
    public const int SUB_MB_LOGON_GAMEID = 1;			//I D登陆
    public const int SUB_GP_LOGON_ACCOUNTS = 2;			//帐号登陆
    public const int SUB_MB_REGISITER_ACCOUNTS = 3;				//注册帐号
    public const int SUB_GP_REGISTER_ACCOUNTS = 3;			//注册帐号
    public const int SUB_GP_GET_PASSPORT = 16;			//获取验证码
    public const int SUB_MB_ANONYMOUS_LOGON = 4;             //手机快速注册登录
    public const int SUB_MB_ANONYMOUS_LOGON_NEO = 8;             //手机快速注册登录
    public const int SUB_MB_SEND_IDENTIFYING = 5;           //完善资料验证码
    public const int SUB_MB_PERFECT_INFO = 6;         //完善资料
    public const int SUB_MB_LOGON_ACCOUNTS_NEO = 9;			//帐号登陆(带手机验证码)
    public const int SUB_GP_CHECK_UPDATE = 40;           //检查后台更新
    public const int SUB_GP_QUERYLABA = 60;                             //查询喇叭
    public const int SUB_GP_QUERY_MESSAGE = 70;              //请求大厅喇叭
    public const int SUB_GP_REISTER_TPYE = 71;            //请求注册类型
    //登陆结果
    public const int SUB_GP_GET_PASSPORT_SUCCESS = 110;				//获取注册验证码成功
    public const int SUB_GP_LOGON_SUCCESS = 100;			//登录成功
    public const int SUB_GP_LOGON_FAILURE = 101;				//登录失败
    public const int SUB_GP_LOGON_FINISH = 102;				//登录完成
    public const int SUB_GP_UPDATE_RETRUN = 115;
    public const int SUB_GP_NEXT_UPDATE = 116;                                //没更新 下一次检查时间

    public const int SUB_MB_PERFECT_SUCCESS = 102;            //手机完善资料成功
    public const int SUB_MB_PERFECT_FAILURE = 103;			//手机完善资料失败
    public const int SUB_MB_SEND_FINISH = 104;       //手机验证码发送完成
    public const int SUB_MB_VERIFYFAILURE = 105;       //验证码验证失败
    public const int SUB_GP_CONSTRAINT = 130;                                  //强制更新新版本下载
    public const int SUB_GP_GET_PLAZA_MESSAGECONTS = 150;                            //大厅喇叭同步数量
    public const int SUB_GP_GET_SPEAKERINFO = 160;                              //喇叭内容
    public const int SUB_GP_SPEAKER_FINISH = 170;                             //喇叭发送完成
    public const int SUB_GP_REGISTER_TYPE_SUCCESS = 171;

    //升级提示
    public const int SUB_GP_UPDATE_NOTIFY = 200;								//升级提示

    public const int MDM_GP_SERVER_LIST = 2;						//列表信息

    public const int SUB_GP_LIST_TYPE = 100;							//类型列表
    public const int SUB_GP_LIST_KIND = 101;						//种类列表
    public const int SUB_GP_LIST_SERVER = 104;                         //房间列表
    public const int SUB_GP_GET_SYSTEM_MESSAGE = 108;                              //获取公告
    public const int SUB_GP_GET_NEWSUM = 109;                           //获取公告数量
    public const int SUB_GP_LIST_FINISH = 200;						//发送完成
    //升级提示
    public const int SUB_MB_UPDATE_NOTIFY = 200;			//升级提示

    //appCheck
    public const int MDM_MB_LOGON = 100;
    public const int SUB_MB_IOS_CHECK_VER = 10;        //请求是否更新，是否全显示
    public const int SUB_GP_IOS_CHECKVER = 113;        //成功

    //TODO:服务命令
    public const int MDM_GP_USER_SERVICE = 3;                                  //用户服务

    //帐号服务
    public const int SUB_GP_MODIFY_MACHINE = 100;                              //修改机器
    public const int SUB_GP_MODIFY_LOGON_PASS = 101;                              //修改密码
    public const int SUB_GP_MODIFY_INSURE_PASS = 102;                             //修改密码
    public const int SUB_GP_MODIFY_UNDER_WRITE = 103;                            //修改签名

    public const int SUB_GP_USER_FACE_INFO = 200;						//头像信息
    public const int SUB_GP_SYSTEM_FACE_INFO = 201;							//系统头像

    public const int SUB_GP_USER_INDIVIDUAL = 301;						//个人资料
    public const int SUB_GP_QUERY_INDIVIDUAL = 302;							//查询信息
    public const int SUB_GP_MODIFY_INDIVIDUAL = 303;							//修改资料

    //银行服务
    public const int SUB_GP_USER_SAVE_SCORE = 400;						//存款操作
    public const int SUB_GP_USER_TAKE_SCORE = 401;							//取款操作
    public const int SUB_GP_USER_TRANSFER_SCORE = 402;							//转账操作
    public const int SUB_GP_QUERY_INSURE_INFO = 404;							//查询银行
    public const int SUB_GP_USER_INSURE_INFO = 403;							//银行资料
    public const int SUB_GP_USER_INSURE_SUCCESS = 405;							//银行成功
    public const int SUB_GP_USER_INSURE_FAILURE = 406;						//银行失败
    public const int SUB_GP_QUERY_USER_INFO_REQUEST = 407;						//查询用户
    public const int SUB_GP_QUERY_USER_INFO_RESULT = 408;						//用户信息
    public const int SUB_GP_USER_LOGONBANK = 409;			    //登录银行
    public const int SUB_GP_LOGONBANK_SUCCESS = 410;				    //登录银行
    public const int SUB_GP_LOGONBANK_FAILURE = 411;					    //登录银行
    public const int SUB_GP_QUERY_BANK_DETAIL = 412;
    public const int SUB_GP_BANK_DETAIL_RESULT = 413;
    public const int SUB_GR_QUERY_RETURN = 419;
    public const int SUB_GR_GETUSER_SCORE = 420;
    public const int SUB_GR_QUERY_RETURN_SCORE = 430;
    public const int SUB_CHANGE_RETURN_INFO = 431;
    //操作结果
    public const int SUB_GP_OPERATE_SUCCESS = 900;							//操作成功
    public const int SUB_GP_OPERATE_FAILURE = 901;                            //操作失败


    public const int DTP_GP_UI_NICKNAME = 1;							//用户昵称
    public const int DTP_GP_UI_USER_NOTE = 2;							//用户说明
    public const int DTP_GP_UI_UNDER_WRITE = 3;							//个性签名
    public const int DTP_GP_UI_QQ = 4;							//Q Q 号码
    public const int DTP_GP_UI_EMAIL = 5;							//电子邮件
    public const int DTP_GP_UI_SEAT_PHONE = 6;								//固定电话
    public const int DTP_GP_UI_MOBILE_PHONE = 7;							//移动电话
    public const int DTP_GP_UI_COMPELLATION = 8;							//真实名字
    public const int DTP_GP_UI_DWELLING_PLACE = 9;						//联系地址


    /////////////////房间登录//////////////////////////////////////////////////////////
    //登录命令
    public const int MDM_GR_LOGON = 1;							//登录信息


    public const int SUB_GR_LOGON_USERID = 1;							//id 登录

    public const int SUB_GR_LOGON_SUCCESS = 100;							//登录成功
    public const int SUB_GR_LOGON_FAILURE = 101;							//登录失败
    public const int SUB_GR_LOGON_FINISH = 102;                             //登录完成
    public const int SUB_GR_LOGON_IPLIST = 103;								//下发IP

    public const int SUB_GR_UPDATE_NOTIFY = 200;						//升级提示


    /////////////////////房间配置/////////////////////////////////////////////////////
    public const int MDM_GR_CONFIG = 2;							//配置信息

    public const int SUB_GR_CONFIG_COLUMN = 100;							//列表配置
    public const int SUB_GR_CONFIG_SERVER = 101;						//房间配置
    public const int SUB_GR_CONFIG_PROPERTY = 102;							//道具配置
    public const int SUB_GR_CONFIG_FINISH = 103;						//配置完成
    public const int SUB_GR_CONFIG_USER_RIGHT = 104;							//玩家权限

    /////////////////////////////////////////////////////////////////////////////////
    public const int MDM_GR_USER = 3;							//用户信息


    /////////////////////////////////////////////////////////////////////////////////
    public const int MDM_GP_HORN_LOGON = 11;
    public const int SUB_GP_HORN_BIG = 1;                                //大喇叭
    public const int SUB_GP_GetUSERPROP = 2;
    public const int SUB_GR_HORN_BIG = 101;
    public const int SUB_GR_PROP_COST = 102;
    public const int SUB_GR_SEND_SUCCESS = 103;
    public const int SUB_GR_SEND_Failure = 104;


    /////////////////////////////////////////////////////////////////////////////////
    //用户动作
    public const int SUB_GR_USER_RULE = 1;					//用户规则
    public const int SUB_GR_USER_LOOKON = 2;								//旁观请求
    public const int SUB_GR_USER_SITDOWN = 3;								//坐下请求
    public const int SUB_GR_USER_STANDUP = 4;								//起立请求
    public const int SUB_GR_USER_INVITE = 5;								//用户邀请
    public const int SUB_GR_USER_INVITE_REQ = 6;							//邀请请求
    public const int SUB_GR_USER_REPULSE_SIT = 7;							//拒绝玩家坐下
    public const int SUB_GR_USER_KICK_USER = 8;                             //踢出用户
    public const int SUB_GR_USER_INFO_REQ = 9;                              //请求用户信息
    public const int SUB_GR_USER_CHAIR_REQ = 10;                             //请求更换位置
    public const int SUB_GR_USER_CHAIR_INFO_REQ = 11;                                //请求椅子用户信息
    public const int SUB_GR_USER_WAIT_DISTRIBUTE = 12;							//等待分配
    public const int SUB_GR_USER_CONTROL = 13;
    public const int SUB_GR_USER_DISTRIBUTION = 14;							//分配请求
    public const int SUB_GR_REQUEST_PROPERTY_COST = 60;                          //
    public const int SUB_GR_QUEST_PROPERTY_SUCCESS = 70;                          //发送道具价格成功

    //-------------------//控制命令
    public const int SUB_GR_USER_CONTROL_XM = 15;                         //用户控制命令，点击控制按钮         
    public const int SUB_GR_USER_LOGON_MASTER = 16;                          //用户控制登录


    //用户状态
    public const int SUB_GR_USER_ENTER = 100;							//用户进入
    public const int SUB_GR_USER_SCORE = 101;							//用户分数
    public const int SUB_GR_USER_STATUS = 102;							//用户状态
    public const int SUB_GR_REQUEST_FAILURE = 103;								//请求失败
    public const int SUB_GR_REQUEST_SUCCESS = 104;							//请求成功
    public const int SUB_GR_MASTERLOGON_FAILURE = 105;							//请求成功
    public const int SUB_GR_IPHONE_SUCCESS = 106;                            //手机检测成功

    //----------发送命令-ID输赢控制
    public const int SUB_GR_USER_CONTROL_XMS = 115;                          //发送信息 弹出控制框
    public const int SUB_GR_USER_CONTROL_XMS_ONE = 116;                             //发送被控人数，服务器—》客户端


    public const int SUB_GR_USER_CONTROL_XMS_PM = 117;                         //发送被控pc和mob，客户端 —》服务器
    public const int SUB_GR_USER_CONTROL_XMS_CON = 118;                           //发送被控人，客户端 —》服务器
    public const int SUB_GR_USER_CONTROL_XMS_ROM = 119;                            //发送删除的控制者，客户端 —》服务器

    public const int SUB_GR_USER_CONTROL_XMS_UPONE = 120;                          //发送被控人数，服务器—》客户端
    public const int SUB_GR_USER_CONTROL_XMS_UPTAB = 121;                            //发送被控人数，服务器—》客户端
    public const int SUB_GR_USER_CONTROL_XMS_FINSH = 122;                           //发送被控人数，服务器—》客户端
    public const int SUB_GR_USER_CONTROL_XMS_DELONE = 123;                           //发送被控人数，服务器—》客户端
    //---------发送命令-Table输赢控制

    public const int SUB_GR_USER_CONTROL_TAB = 130;                        //发送信息 弹出控制框  客户端 —》服务器
    public const int SUB_GR_USER_CONTROL_TAB_ONE = 131;                            //发送信息 读出文件  服务器—》客户端

    public const int SUB_GR_USER_CONTROL_TAB_CHANG = 132;                        //发送信息 确定操作
    //public const int SUB_GR_USER_CONTROL_TAB_ROM          123                             //发送信息 删除操作
    /////////////////////////////////////////////////////////////////////////////////

    //聊天命令
    public const int SUB_GR_USER_CHAT = /*201*/ 211;						//聊天消息
    public const int SUB_GR_USER_EXPRESSION = /*202*/ 212;							//表情消息
    public const int SUB_GR_WISPER_CHAT = /*203*/ 213;							//私聊消息
    public const int SUB_GR_WISPER_EXPRESSION = /*204*/ 214;							//私聊表情
    public const int SUB_GR_COLLOQUY_CHAT = /*205*/ 215;						//会话消息
    public const int SUB_GR_COLLOQUY_EXPRESSION = /*206*/ 216;							//会话表情
    //包裹命令
    public const int SUB_GR_USER_PACKAGE = 250;					//包裹消息
    public const int SUB_GR_UPDATE_PACKAGE = 251;						//更新包裹
    //道具命令
    public const int SUB_GR_PROPERTY_BUY = 300;							//购买道具
    public const int SUB_GR_PROPERTY_SUCCESS = 301;								//道具成功
    public const int SUB_GR_PROPERTY_FAILURE = 302;							//道具失败
    public const int SUB_GR_PROPERTY_MESSAGE = 303;                             //道具消息
    public const int SUB_GR_PROPERTY_EFFECT = 304;                         //道具效应
    public const int SUB_GR_PROPERTY_TRUMPET = 305;                           //喇叭消息
    public const int SUB_GR_PROPERTY_BUY_IN = 306;						//买入道具
    public const int SUB_GR_PROPERTY_USE = 307;							//使用道具
    public const int SUB_GR_PROPERTY_TRUMPET_NEW = 308;                      //新的喇叭消息
    /////////////////////////////////////////////////////////////////////////////////
    public const int MDM_GR_STATUS = 4;						//状态信息

    public const int SUB_GR_TABLE_INFO = 100;						//桌子信息
    public const int SUB_GR_TABLE_STATUS = 101;							//桌子状态


    //////////////////////////////////////////////////////////////////////////////////
    //银行命令

    public const int MDM_GR_INSURE = 5;								//用户信息

    //银行命令
    public const int SUB_GR_QUERY_INSURE_INFO = 1;							//查询银行
    public const int SUB_GR_SAVE_SCORE_REQUEST = 2;						//存款操作
    public const int SUB_GR_TAKE_SCORE_REQUEST = 3;							//取款操作
    public const int SUB_GR_TRANSFER_SCORE_REQUEST = 4;						//取款操作
    public const int SUB_GR_QUERY_USER_INFO_REQUEST = 5;							//查询用户
    public const int SUB_GR_QUERY_BANK_DETAIL = 9;                         //查询明细
    public const int SUB_GR_QUERY_RETURN_SERVER = 10;                            //查询返回
    public const int SUB_GR_GETUSER_SCORE_SERVER = 11;                             //返点

    public const int SUB_GR_ANDROID_SAVE_SCORE_REQUEST = 6;						//机器人存款
    public const int SUB_GR_ANDROID_TAKE_SCORE_REQUEST = 7;						//机器人取款
    public const int SUB_GR_ANDROID_ZERO_TAKE_SCORE_REQUEST = 8;					//机器人补款


    public const int SUB_GR_USER_INSURE_INFO = 100;							//银行资料
    public const int SUB_GR_USER_INSURE_SUCCESS = 101;							//银行成功
    public const int SUB_GR_USER_INSURE_FAILURE = 102;							//银行失败
    public const int SUB_GR_USER_TRANSFER_USER_INFO = 103;						//用户资料
    public const int SUB_GR_USER_PASSWORD_RESULT = 104;							//查询密码
    public const int SUB_GR_USER_CHANGE_RESULT = 105;						//修改结果
    public const int SUB_GR_BANK_DETAIL_RESULT = 106;					//银行记录
    public const int SUB_GR_QUERY_RETURN_SCORE_SERVER = 107;                     //返回发送
    public const int SUB_CHANGE_RETURN_INFO_SERVER = 108;
    //管理消息;
    public const int MDM_GR_MANAGE = 6;								//管理命令

    public const int SUB_GR_SEND_WARNING = 1;							//发送警告
    public const int SUB_GR_SEND_MESSAGE = 2;							//发送消息
    public const int SUB_GR_LOOK_USER_IP = 3;								//查看地址
    public const int SUB_GR_KILL_USER = 4;						//踢出用户
    public const int SUB_GR_LIMIT_ACCOUNS = 5;								//禁用帐户
    public const int SUB_GR_SET_USER_RIGHT = 6;								//权限设置

    //房间设置
    public const int SUB_GR_QUERY_OPTION = 7;							//查询设置
    public const int SUB_GR_OPTION_SERVER = 8;							//房间设置
    public const int SUB_GR_OPTION_CURRENT = 9;							//当前设置

    public const int SUB_GR_LIMIT_USER_CHAT = 10;							//限制聊天

    public const int SUB_GR_KICK_ALL_USER = 11;							//踢出用户
    public const int SUB_GR_DISMISSGAME = 12;							//解散游戏
    public const int SUB_GR_ADDANDIRO = 13;							//解散游戏
    public const int SUB_GR_DELANDIRO = 14;							//解散游戏

    public const int MDM_CM_SYSTEM = 1000;						//系统命令

    public const int SUB_CM_SYSTEM_MESSAGE = 1;								//系统消息
    public const int SUB_CM_ACTION_MESSAGE = 2;								//动作消息
    public const int SUB_CM_DOWN_LOAD_MODULE = 3;							//下载消息

    //////////////////////////////////////////////////////////////////////////////////

    //类型掩码
    public const int SMT_CHAT = 0x0001;						//聊天消息
    public const int SMT_EJECT = 0x0002;						//弹出消息
    public const int SMT_GLOBAL = 0x0004;						//全局消息
    public const int SMT_PROMPT = 0x0008;						//提示消息
    public const int SMT_TABLE_ROLL = 0x0010;						//滚动消息

    //控制掩码
    public const int SMT_CLOSE_ROOM = 0x0100;							//关闭房间
    public const int SMT_CLOSE_GAME = 0x0200;							//关闭游戏
    public const int SMT_CLOSE_LINK = 0x0400;						//中断连接

    //动作类型
    public const int ACT_BROWSE = 1;							//浏览动作
    public const int ACT_DOWN_LOAD = 2;								//下载动作

    //浏览类型
    public const int BRT_IE = 0x01;					//I E 浏览
    public const int BRT_PLAZA = 0x02;						//大厅浏览
    public const int BRT_WINDOWS = 0x04;						//窗口浏览

    //下载类型
    public const int DLT_IE = 1;					//I E 下载
    public const int DLT_MODULE = 2;							//下载模块


    //游戏命令
    public const int MDM_GF_GAME = 200;						//游戏命令
    //框架命令
    public const int MDM_GF_FRAME = 100;						//框架命令

    //用户命令
    public const int SUB_GF_GAME_OPTION = 1;							//游戏配置
    public const int SUB_GF_USER_READY = 2;						//用户准备
    public const int SUB_GF_LOOKON_CONFIG = 3;							//旁观配置

    //聊天命令
    public const int SUB_GF_USER_CHAT = 10;						//用户聊天
    public const int SUB_GF_USER_EXPRESSION = 11;							//用户表情

    //游戏信息
    public const int SUB_GF_GAME_STATUS = 100;							//游戏状态
    public const int SUB_GF_GAME_SCENE = 101;						//游戏场景
    public const int SUB_GF_LOOKON_STATUS = 102;							//旁观状态

    //系统消息
    public const int SUB_GF_SYSTEM_MESSAGE = 200;							//系统消息

    public const int SUB_GF_ACTION_MESSAGE = 201; //动作消息

    //答题消息
    public const int MDM_MAIN_LOGON_QUESTION = 10;

    public const int SUB_LOGON_QUESTION = 9;
    public const int SUB_QUESTION_ANSWER = 8;
    public const int SUB_REWARDS_COUNT = 7;  //获得奖励用户
    public const int SUB_REWARDS_RESULT = 6; //写奖励
    public const int SUB_REQUEST_NUM = 5;

    public const int MDM_MISSION_QUESTION = 20;
    public const int SUB_MISSION_C_QUESTION = 19;
    public const int SUB_MISSION_SUCCESS = 18;
    public const int SUB_MISSION_COUNT = 17;
    public const int SUB_MISSION_C_REWARDS = 16;//随机奖励数量
    public const int SUB_MISSION_C_LUCK_RESULT = 15;  //转盘是否开始
    public const int SUB_MISSION_NUM = 14;


    public const int IPC_CMD_GF_CONFIG = 3; //

    public const int IPC_SUB_GF_CONFIG_FINISH = 104;                                    //配置完成
                                                                                        //public const int SUB_GF_GAME_SCENE = 101;
}
