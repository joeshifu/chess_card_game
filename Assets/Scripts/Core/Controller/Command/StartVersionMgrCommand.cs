using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using LuaFramework;
using XGame.Event;

public class StartVersionMgrCommand : ControllerCommand
{
    GameObject inst_downloadPanel;
    GameObject m_versionMgrGo;

    ResourceManager ResMgr
    {
        get
        {
            return AppFacade.Instance.GetManager<ResourceManager>(ManagerName.Resource);
        }
    }

    LuaManager LuaMgr
    {
        get
        {
            return AppFacade.Instance.GetManager<LuaManager>(ManagerName.Lua);
        }
    }

    NetworkManager NetworkMgr
    {
        get
        {
            return AppFacade.Instance.GetManager<NetworkManager>(ManagerName.Network);
        }
    }

    PanelManager PanelMgr
    {
        get
        {
            return AppFacade.Instance.GetManager<PanelManager>(ManagerName.Panel);
        }
    }

    public override void Execute(IMessage message)
    {
        object data = message.Body;
        if (data == null)
            return;

        StartVersionCtrl();
    }

    private void StartVersionCtrl()
    {
        inst_downloadPanel = PanelMgr.CreatePanelFromResources("UI/Prefab/DownloadPanel");
        inst_downloadPanel.AddComponent<DownloadPanelScript>();

        m_versionMgrGo = new GameObject();
        m_versionMgrGo.name = "VersionMgr";
        VersionMgr m_versionMgr = m_versionMgrGo.AddComponent<VersionMgr>();
        m_versionMgr.InitStart(VersionMgrFinished);
    }

    /// <summary>
    /// 版本管理结束
    /// </summary>
    private void VersionMgrFinished()
    {
        if (m_versionMgrGo != null)
            GameObject.Destroy(m_versionMgrGo);

        OnResourceInited();
    }

    /// <summary>
    /// 资源初始化结束
    /// </summary>
    public void OnResourceInited()
    {
#if ASYNC_MODE
        ResMgr.Initialize(AppConst.AssetDir, delegate ()
        {
            Debug.Log("Initialize OK!!!");
            this.OnInitialize();
        });
#else
            ResMgr.Initialize();
            this.OnInitialize();
#endif
    }

    void OnInitialize()
    {
        LuaMgr.InitStart();

        LuaMgr.DoFile("Logic/XGame");        //加载游戏
        LuaMgr.DoFile("Logic/Network");      //加载网络
        NetworkMgr.Init();                     //初始化网络
        Util.CallMethod("XGame", "OnInitOK");    //初始化完成

        if(inst_downloadPanel!=null)
            GameObject.Destroy(inst_downloadPanel);

        XPageMgr.Inst.ShowPage(true, "UI/Prefab/LoginPanel");
        EventDispatcher.TriggerEvent("test");
        //EventDispatcher.TriggerEvent<int>("testint", 111);
    }

}
