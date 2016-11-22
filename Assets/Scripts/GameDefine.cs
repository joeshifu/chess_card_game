using System;




public class GameDefine
{
    public const int BEGINFLAG = 0x55555555;
    public const int ENDFLAG = 0x66666666;

    public const int VIEW_MODE_ALL = 0x0001;                           //全部可视
    public const int VIEW_MODE_PART = 0x0002;                      //部分可视


    public const int BEHAVIOR_LOGON_NORMAL = 0x0000;                           //普通登录
    public const int BEHAVIOR_LOGON_IMMEDIATELY = 0x1000;                          //立即登录


    //分页设置
    public const int PAGE_ROOM_COUNT = 6;
    public const int PAGE_TABLE_COUNT = 9;

    //头像大小
    public const int FACE_CX = 48;         //头像宽度
    public const int FACE_CY = 48;         //头像高度

    //长度定义
    public const int LEN_LESS_ACCOUNTS = 3;                    //最短帐号
    public const int LEN_LESS_NICKNAME = 3;                    //最短昵称
    public const int LED_LESSPASSWORD = 6;             //最短密码

    //人数定义
    public const int MAX_CHAIR = 100;          //最大椅子
    public const int MAX_TABLE = 512;              //最大桌子
    public const int MAX_COLUMN = 32;              //最大列表
    public const int MAX_ANDROID = 256;                //最大机器
    public const int MAX_PROPORTY = 128;               //最大道具
    public const int MAX_WHISPER_USER = 16;                //最大私聊

    //裂表定义
    public const int MAX_KIND = 128;       //最大类型
    public const int MAX_SERVER = 1024;            //最大房间

    //参数定义
    public const int INVALID_CHAIR = 0xFFFF;                   //无效椅子
    public const int INVALID_TABLE = 0xFFFF;               //无效桌子
    public const int INVALID_USERID = 0;           //无效用户

    //税收起点
    public const Int64 REVENUE_BENCHMARK = 1000L;                //税收起点
    public const Int64 REVENUE_DENOMINATOR = 1000L;              //税收分母

    //游戏状态
    public const int GAME_STATUS_FREE = 0;         //空闲状态
    public const int GAME_STATUS_PLAY = 100;               //游戏状态
    public const int GAME_STATUS_WAIT = 200;               //等待状态
    public const int GAME_STATUS_ENDED = 255;                   //结束状态

    //系统参数
    public const int LEN_USER_CHAT = 128;                  //聊天长度
    public const Int64 TIME_USER_CHAT = 1L;                  //聊天间隔
    public const int TRUMPET_MAX_CHAR = 128;              //喇叭长度


    //列表质数
    public const Int64 PRIME_TYPE = 11L;                 //种类数目
    public const Int64 PRIME_KIND = 53L;                 //类型数目
    public const Int64 PRIME_NODE = 101L;                    //节点数目
    public const Int64 PRIME_PAGE = 53L;         //自定树木
    public const Int64 PRIME_SERVER = 1009L;             //房间树木

    //人物质数
    public const Int64 PRIME_SERVER_USER = 503L;             //房间人数
    public const Int64 PRIME_ANDROID_USER = 503L;                //机器人数
    public const Int64 PRIME_PLATFORM_USER = 100003L;                //平台人数


    //资料数据
    public const int LEN_MD5 = 33;         //加密密码
    public const int LEN_ACCOUNTS = 32;                //备注长度
    public const int LEN_PASS_PORT_ID = 19;                //证件号码长度
    public const int LEN_NICENAME = 32;            //帐号长度	
    public const int LEN_NICKNAME = 32;            //昵称长度
    public const int LEN_PASSWORD = 33;                //密码长度	
    public const int LEN_GROUP_NAME = 32;              //社团名字	
    public const int LEN_UNDER_WRITE = 32;                 //个性签名

    //数据长度
    public const int LEN_QQ = 16;          //q q号码
    public const int LEN_EMAIL = 33;       //电子邮件
    public const int LEN_USER_NOTE = 256;              //用户备注
    public const int LEN_SEAT_PHONE = 33;          //固定电话
    public const int LEN_MOBILE_PHONE = 12;                    //移动电话
    public const int Len_PASS_PORT_ID = 19;            //证件号码
    public const int LEN_COMPELLATION = 16;                //真实名字
    public const int LEN_DWELLING_PLACE = 128;             //联系地址

    public const int LEN_QUESTION = 256;
    public const int LEN_ANSWER = 30;
    public const int LEN_LUCKY_RESULT = 10;

    //机器标识
    public const int LEN_MACHINE_ID = 33;              //序列长度
    public const int LEN_NETWORK_ID = 13;              //网卡长度

    //列表数据
    public const int LEN_TYPE = 32;                //种类长度
    public const int LEN_KIND = 32;                    //类型长度	
    public const int LEN_NODE = 32;            //节点长度
    public const int LEN_PAGE = 32;                    //定制长度
    public const int LEN_SERVER = 32;      //房间长度
    public const int LEN_PROCESS = 32;         //进程长度


    public const int CP_NORMAL = 0;            //未知关系
    public const int CP_ERIEND = 1;            //好友关系
    public const int CP_DETEST = 2;            //厌恶关系

    public const int GENDER_FRMALE = 0;            //女性性别
    public const int GENDER_MANKIND = 1;               //男性性别

    public const int GAME_GENRE_GOLD = 0x0001;             //金币类型
    public const int GAME_GENRE_SCORE = 0x0002;            //点值类型
    public const int GAME_GENRE_EDUCATE = 0x0003;              //比赛类型
    public const int GAME_GENREMATCH = 0x0004;                 //训练类型


    public const int SCORE_GENRE_NORMAL = 0x0100;      //普通模式
    public const int SCORE_GENRE_POSITIVE = 0x0200;        //非负模式


    public const int US_NULL = 0x00;               //没有状态
    public const int US_FREE = 0x01;           //站立状态
    public const int US_SIT = 0x02;                //坐下状态
    public const int US_READY = 0x03;              //同意状态
    public const int US_LOOKON = 0x04;             //旁观状态
    public const int US_PLAYING = 0x05;            //游戏状态
    public const int US_OFFLINE = 0x06;                //断线状态


    public const int SRL_LOOKON = 0x00000001;      //旁观标志
    public const int SRL_OFFLINE = 0x00000002;         //断线标志
    public const int SRL_SAME_IP = 0x00000004;         //同网标志

    public const int SRL_ROOM_CHAT = 0x00000100;           //聊天标志
    public const int SRL_GAME_CHAT = 0x00000200;       //聊天标志
    public const int SRL_WISPER_CHAT = 0x00000400;         //私聊标志
    public const int SRL_HIDE_USER_INFO = 0x00000800;          //隐藏标志

    //无效属性
    public const int UD_NULL = 0;          //无效子项
    public const int UD_IMAGE = 100;           //图形子项

    //基本属性
    public const int UD_GAME_ID = 1;               //游戏标识
    public const int UD_USER_ID = 2;               //用户标识
    public const int UD_NICKNAME = 3;              //用户昵称
                                                   //扩展属性
    public const int UD_GENDER = 10;               //用户性别
    public const int UD_GROUP_NAME = 11;                   //社团名字
    public const int US_UNDER_WRITE = 12;              //个性签名

    //状态信息
    public const int UD_TABLE = 20;                        //游戏桌号
    public const int UD_CHAIR = 21;                    //椅子号码

    //积分信息
    public const int UD_SCORE = 30;                    //用户分数
    public const int UD_BANKER = 31;                   //用户银行
    public const int UD_EXPERIENCE = 32;                   //用户经验
    public const int UD_LOVELINESS = 33;                   //用户魅力
    public const int UD_WIN_COUNT = 34;                //胜利盘数
    public const int UD_LOSE_COUNT = 35;                   //输局盘数 
    public const int UD_DRAW_COUNT = 36;                   //和局盘数
    public const int UD_FLEE_COUNT = 37;                   //逃局盘数
    public const int UD_PLAY_COUNT = 38;               //总局盘数

    //积分比率
    public const int UD_WIN_RATE = 40;                 //用户胜率
    public const int UD_LOSE_RATE = 41;                    //用户输率
    public const int UD_DRAW_RATE = 42;                    //用户和率
    public const int UD_FLEE_RATE = 43;                //用户逃率
    public const int UD_GAME_LEVEL = 44;                   //游戏等级

    //扩展信息
    public const int UD_NOTE_INFO = 50;                //用户备注
    public const int UD_LOOKON_USER = 51;                  //旁官用户

    //图像列表
    public const int UD_FLAG = (UD_IMAGE + 1);     //用户标志
    public const int UD_STATUS = (UD_IMAGE + 2);       //用户状态

    public const int DB_ERROR = -1;                //处理失败
    public const int DB_SUCCESS = 0;               //处理成功

    //携带信息

    //其他信息
    public const int DTP_GR_TABLE_PASSWORD = 1;                            //桌子密码

    //用户属性
    public const ushort DTP_GR_NICK_NAME = 10;                //用户昵称
    public const ushort DTP_GR_GROUP_NAME = 11;                       //社团名字
    public const ushort DTP_GR_UNDER_WRITE = 12;                          //个性签名
    public const ushort DTP_GR_USER_QQ = 13;

    //附加信息
    public const int DTP_GR_USER_NOTE = 20;                            //用户备注
    public const int DTP_GR_CUSTOM_FACE = 21;                          //自定头像

    //发行范围
    public const int PT_ISSUE_AREA_WEB = 0x01;                     //商城道具
    public const int PT_ISSUE_AREA_GAME = 0x02;                        //游戏道具
    public const int PT_ISSUE_AREA_SERVER = 0x04;                          //房间道具

    public const int PROPERTY_ID_TRUMPET = 19;                         //喇叭道具
    public const int PROPERTY_ID_TYPHON = 20;                          //喇叭道具

    //变化原因
    public const int SCORE_REASON_WRITE = 0;                               //写分变化
    public const int SCORE_REASON_INSURE = 1;                            //银行变化
    public const int SCORE_REASON_PROPERTY = 2;                             //道具变化
    public const int SCORE_REASON_MATCH_FEE = 3;                              //比赛报名
    public const int SCORE_REASON_MATCH_QUIT = 4;                                //比赛退赛

    //Macro.h
    ///////////////////////////////////////////////////////////////////////
    //常用常量

    //无效数值
    public const int INVALID_BYTE = ((byte)(0xff));        //无效数值
    public static uint INVALID_WORD = 0xffff;  //无效数值
    public static uint INVALID_DWORD = 0xffffffff;    //无效数值

    public const int DEVICE_TYPE_ITOUCH = 0x20;                        //iTouch
    public const int DEVICE_TYPE_IPHONE = 0x40;                            //iPhone
    public const int DEVICE_TYPE_IPAD = 0x80;                      //iPad
    public const int DEVICE_TYPE_DEFAULT = DEVICE_TYPE_IPHONE;

    public const int PRODUCT_VER = 6;  //产品版本


    //程序版本
    public const int VERSION_PLAZA = 1;            //大厅版本

    public const int LOGON_KIND_ID = 25;

    /////////////////////////////////////////////////////////////////////
    //端口定义
    public const int MAX_CONTENT = 512;                    //并发容量
    public static uint PORT_AUTO_SELECT = 0XFFFF;      //自动端口

    public const int PORT_TEMP = 6300;
    public const int PORT_LOGON = 8300;                //登陆端口
    public const int PORT_CENTER = 8310;               //协调端口
    public const int PORT_8311 = 8311;         //测试端口
    public const int PORT_MANAGER = 8320;              //管理端口

    /////////////////////////////////////////////////////////////////////
    //网络定义

    //数据类型
    public const int DK_MAPPED = 0X01;             //映射类型
    public const int DK_ENCRYPT = 0X02;                //加密类型
    public const int DK_COMPRESS = 0X04;               //压缩类型


    public const int SOCKET_VER = 68;                      //数据包版本

    public const int MDM_KN_COMMAND = 0;               //内核命令
    public const int SUB_KN_DETECT_SOCKET = 1;                 //检测命令
    public const int SUB_KN_VALIDATE_SOCKET = 2;                   //验证命令

    public const int MDM_KN_COMMAND_LAJI = 65534;                          //内核命令
    public const int MDM_KN_COMMAND_LAJI2 = 65533;                         //内核命令
    public const int MDM_KN_COMMAND_LAJI3 = 65532;                     //内核命令
    public const int MDM_KN_COMMAND_LAJI4 = 65531;                     //内核命令
    public const int MDM_KN_COMMAND_LAJI5 = 65530;                     //内核命令
    public const int MDM_KN_COMMAND_LAJI6 = 65529;                             //内核命令

    public const int IDI_CHECK_TIMER = 1034;
    public const int IDI_MONITOR_REF_TIMER = 1040;
    public const int IDI_FLUSHPROGRESS = 1041;


    //登录服务器端口
    public const int LOGIN_PORT = 11000;//11000;
                                        //银行服务器端口
    public const int BANK_PORT = 11000;



    //任务服务器端口
    public const int MISSION_PORT = 18226;
    //喇叭服务器端口
    public const int SPEAKER_PORT = 16049;

    //端口便宜
    public const int OFFSET_SERVER_PORT = 5000;

    public const int INITIAL_WIDTH = 1288;
    public const int INITIAL_HIGH = 762;


    public const int PHONE_RES_WIDTH = 960;
    public const int PHONE_RES_HIGH = 640;

    //小游戏
    public const int CLIENT_INITIAL_WIDTH = 1288;
    public const int CLIENT_INITIAL_HIGH = 762;
    //服务状态
    enum enServiceStatus
    {
        ServiceStatus_Unknow,           //未知状态
        ServiceStatus_Entering,         //进入状态
        ServiceStatus_Validate,         //验证状态
        ServiceStatus_RecvInfo,         //读取状态
        ServiceStatus_ServiceIng,       //服务状态
        ServiceStatus_NetworkDown,      //中断状态
    }

}