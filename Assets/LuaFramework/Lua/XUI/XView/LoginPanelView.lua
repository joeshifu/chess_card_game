local transform;
local gameObject;

LoginPanelView = {};
local this = LoginPanelView;


function LoginPanelView.Start(obj)
	gameObject = obj;
	transform = obj.transform;
    --logWarn('LoginPanelView Start--->>>'..gameObject.name);

 	local userNameGo = transform:FindChild("Image_Bg/Image_InputBg/InputField_UserName").gameObject;
 	local passWordGo = transform:FindChild("Image_Bg/Image_InputBg/InputField_PassWord").gameObject;
    this.userName =userNameGo:GetComponent("InputField");
    this.passWord =passWordGo:GetComponent("InputField");
    this.loginBtn = transform:FindChild("Image_Bg/Button_Login").gameObject; 
    this.registerBtn = transform:FindChild("Image_Bg/Button_Register").gameObject;
    this.weChatLoginBtn = transform:FindChild("Image_Bg/Button_WeChatLogin").gameObject;
end

