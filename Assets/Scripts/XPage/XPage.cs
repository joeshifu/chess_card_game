using System;
using UnityEngine;
using System.Collections;
using Object = UnityEngine.Object;
using LuaFramework;

public enum EPageType
{
    None,
    Normal,
    PopUp,
    Fixed,
    //    Toppest,
}

public enum EPageMode
{
    DoNothing,
    HideOtherOnly,
    HideOtherAndNeedBack,
}

public enum EPageState
{
    NONE,
    OPEN, //打开
    HIDE, //隐藏
    CLOSE,//销毁
}

public class XPageLoadBind
{
    /// <summary>
    /// 绑定你自己的资源加载管理器
    /// </summary>
    /// <param name="xPage"></param>
    public static void Bind(XPage xPage)
    {
        //binding同步加载方法
        xPage.delegateSyncLoadUI = Resources.Load; //开发过程可以用Resource.Load,  真机调试时: 打包用AssetBundle的非压缩格式,加载用LoadFromFile同步加载.考虑修改ResourceMgr  TODO

        //binding异步加载方法,注:异步我们不用,因为要等回调!即时是AssetBundle,也在loading的时候,预加载到内存,在游戏中,就可以同步的实例化.
        //xPage.delegateAsyncLoadUI =null;// AppFacade.Instance.GetManager<ResourceManager>(ManagerName.Resource).LoadPrefab;//ResourcesMgr.Load;
    }
}

public class XPage
{
    public string m_pageName;
    public string m_loadPath;
    public GameObject m_pageInst;
    public Transform m_pageTrans;
    public EPageType m_pageType = EPageType.None;
    public EPageMode m_pageMode = EPageMode.DoNothing;
    public EPageState m_currState = EPageState.NONE;

    private string m_luaPageCtrl;
    private string m_luaPageView;

    //delegate load ui function.
    public Func<string, Object> delegateSyncLoadUI = null;
    public Action<string, Action<Object>> delegateAsyncLoadUI = null;

    public XPage(string pageName, string loadPath)
    {
        m_pageName = pageName;
        m_loadPath = loadPath;
    }

    public void Awake()
    {
        m_luaPageCtrl = m_pageName + "Ctrl";
        m_luaPageView = m_pageName + "View";
        Util.CallMethod(m_luaPageCtrl, "Awake", this);
    }

    public void Start()
    {
        m_currState = EPageState.OPEN;
        m_pageInst.gameObject.SetActive(true);
        AnchorUIGameObject();
        Util.CallMethod(m_luaPageView, "Start", this.m_pageInst);
        Util.CallMethod(m_luaPageCtrl, "Start");
    }

    public void Rest()
    {
        m_currState = EPageState.OPEN;
        m_pageInst.gameObject.SetActive(true);
        Util.CallMethod(m_luaPageCtrl, "Rest");
    }

    public void Hide()
    {
        m_currState = EPageState.HIDE;
        m_pageInst.gameObject.SetActive(false);
        Util.CallMethod(m_luaPageCtrl, "Hide");
    }

    public void Destroy()
    {
        m_currState = EPageState.CLOSE;
        GameObject.Destroy(m_pageInst);
        Util.CallMethod(m_luaPageCtrl, "Destroy");
    }

    /// <summary>
    /// 同步加载
    /// </summary>
    /// <param name="callback"></param>
    public void LoadSync(Action<GameObject> callback)
    {
        if (this.m_pageInst == null && string.IsNullOrEmpty(m_loadPath) == false)
        {
            GameObject go = null;
            if (delegateSyncLoadUI != null)
            {
                Object o = delegateSyncLoadUI(m_loadPath);
                go = o != null ? GameObject.Instantiate(o) as GameObject : null;
            }
            else
            {
                go = GameObject.Instantiate(Resources.Load(m_loadPath)) as GameObject;
            }

            if (go == null)
            {
                Debug.LogError("[UI] Cant sync load your ui prefab.");
                return;
            }

            m_pageInst = go;
            m_pageTrans = go.transform;

            if (callback != null)
                callback(go);
        }
        else
        {
            if (callback != null)
                callback(m_pageInst);
        }
    }

    /// <summary>
    /// 异步加载
    /// </summary>
    /// <param name="callback"></param>
    public void LoadAsync(Action<GameObject> callback)
    {
        XPageRoot.Instance.StartCoroutine(AsyncShow(callback));
    }

    IEnumerator AsyncShow(Action<GameObject> callback)
    {
        if (this.m_pageInst == null && string.IsNullOrEmpty(m_loadPath) == false)
        {
            GameObject go = null;
            bool _loading = true;
            if (delegateAsyncLoadUI != null)
            {
                delegateAsyncLoadUI(m_loadPath, (o) =>
                {
                    go = o != null ? GameObject.Instantiate(o) as GameObject : null;

                    _loading = false;

                    m_pageInst = go;
                    m_pageTrans = go.transform;

                    if (callback != null)
                        callback(go);
                });
            }
            else
            {
                Debug.LogError("[UI] delegateAsyncLoadUI = null");
            }

            float _t0 = Time.realtimeSinceStartup;
            while (_loading)
            {
                if (Time.realtimeSinceStartup - _t0 >= 10.0f)
                {
                    Debug.LogError("[UI] WTF async load your ui prefab timeout!");
                    yield break;
                }
                yield return null;
            }
        }
        else
        {
            if (callback != null)
                callback(m_pageInst);
        }
    }

    protected void AnchorUIGameObject()
    {
        if (XPageRoot.Instance == null || m_pageInst == null)
            return;

        GameObject ui = m_pageInst;

        //check if this is ugui or (ngui)?
        Vector3 anchorPos = Vector3.zero;
        Vector2 sizeDel = Vector2.zero;
        Vector3 scale = Vector3.one;
        if (ui.GetComponent<RectTransform>() != null)
        {
            anchorPos = ui.GetComponent<RectTransform>().anchoredPosition;
            sizeDel = ui.GetComponent<RectTransform>().sizeDelta;
            scale = ui.GetComponent<RectTransform>().localScale;
        }
        else
        {
            anchorPos = ui.transform.localPosition;
            scale = ui.transform.localScale;
        }

        EPageType type = this.m_pageType;
        if (type == EPageType.Normal)
        {
            ui.transform.SetParent(XPageRoot.Instance.normalRoot);
        }
        else if (type == EPageType.PopUp)
        {
            ui.transform.SetParent(XPageRoot.Instance.popupRoot);
        }
        else if (type == EPageType.Fixed)
        {
            ui.transform.SetParent(XPageRoot.Instance.fixedRoot);
        }
        //else if (type == EPageType.Toppest)
        //{
        //    ui.transform.SetParent(XPageRoot.Instance.ToppestRoot);
        //}

        if (ui.GetComponent<RectTransform>() != null)
        {
            ui.GetComponent<RectTransform>().anchoredPosition = anchorPos;
            ui.GetComponent<RectTransform>().sizeDelta = sizeDel;
            ui.GetComponent<RectTransform>().localScale = scale;
        }
        else
        {
            ui.transform.localPosition = anchorPos;
            ui.transform.localScale = scale;
        }
    }
}
