﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

/// <summary>
/// Init The UI Root
/// </summary>
public class XPageRoot : MonoBehaviour
{
    private static XPageRoot m_Instance = null;
    public static XPageRoot Instance
    {
        get
        {
            if (m_Instance == null)
            {
                InitRoot();
            }
            return m_Instance;
        }
    }

    public Transform root;
    public Transform normalRoot;//Canvas order in layer 0
    public Transform popupRoot;//250
    public Transform fixedRoot;//500
    //public Transform ToppestRoot;//750
    public Camera uiCamera;

    static void InitRoot()
    {
        GameObject _uiRoot = GameObject.Find("UIRoot");
        if (_uiRoot != null)
        {
            DontDestroyOnLoad(_uiRoot);
            m_Instance = _uiRoot.GetComponent<XPageRoot>();
        }
        else
        {
            GameObject go = new GameObject("UIRoot");
            DontDestroyOnLoad(go);
            go.layer = LayerMask.NameToLayer("UI");
            m_Instance = go.AddComponent<XPageRoot>();
            go.AddComponent<RectTransform>();
            m_Instance.root = go.transform;

            Canvas can = go.AddComponent<Canvas>();
            can.renderMode = RenderMode.ScreenSpaceCamera;
            can.pixelPerfect = true;
            GameObject camObj = new GameObject("UICamera");
            camObj.layer = LayerMask.NameToLayer("UI");
            camObj.transform.parent = go.transform;
            camObj.transform.localPosition = new Vector3(0, 0, -100f);
            Camera cam = camObj.AddComponent<Camera>();
            cam.clearFlags = CameraClearFlags.Depth;
            cam.orthographic = true;
            cam.farClipPlane = 200f;
            can.worldCamera = cam;
            m_Instance.uiCamera = cam;
            cam.cullingMask = 1 << 5;
            cam.nearClipPlane = -50f;
            cam.farClipPlane = 50f;

            //add audio listener
            camObj.AddComponent<AudioListener>();
            camObj.AddComponent<GUILayer>();

            CanvasScaler cs = go.AddComponent<CanvasScaler>();
            cs.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
            cs.referenceResolution = new Vector2(1136f, 640f);
            cs.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;

            ////add auto scale camera fix size.
            //TTCameraScaler tcs = go.AddComponent<TTCameraScaler>();
            //tcs.scaler = cs;

            //set the raycaster
            //GraphicRaycaster gr = go.AddComponent<GraphicRaycaster>();

            //add bg
            GameObject bg = new GameObject();
            bg.name = "BG";
            bg.transform.SetParent(go.transform);
            bg.transform.localPosition = Vector3.zero;
            bg.transform.localScale = Vector3.one;
            bg.layer = LayerMask.NameToLayer("UI");
            //TODO 赋值bg sprite


            GameObject subRoot = CreateSubCanvasForRoot(go.transform, 0);
            subRoot.name = "NormalRoot";
            m_Instance.normalRoot = subRoot.transform;

            subRoot = CreateSubCanvasForRoot(go.transform, 250);
            subRoot.name = "PopupRoot";
            m_Instance.popupRoot = subRoot.transform;

            subRoot = CreateSubCanvasForRoot(go.transform, 500);
            subRoot.name = "FixedRoot";
            m_Instance.fixedRoot = subRoot.transform;

            //subRoot = CreateSubCanvasForRoot(go.transform, 750);
            //subRoot.name = "ToppestRoot";
            //m_Instance.ToppestRoot = subRoot.transform;

            //add Event System
            GameObject esObj = GameObject.Find("EventSystem");
            if (esObj != null)
            {
                GameObject.DestroyImmediate(esObj);
            }

            GameObject eventObj = new GameObject("EventSystem");
            eventObj.layer = LayerMask.NameToLayer("UI");
            eventObj.transform.SetParent(go.transform);
            eventObj.transform.localScale = Vector3.one;
            eventObj.AddComponent<EventSystem>();
            if (!Application.isMobilePlatform || Application.isEditor)
            {
                eventObj.AddComponent<UnityEngine.EventSystems.StandaloneInputModule>();
            }
            else
            {
                eventObj.AddComponent<UnityEngine.EventSystems.TouchInputModule>();
            }
        }
    }

    static GameObject CreateSubCanvasForRoot(Transform root, int sort)
    {
        GameObject go = new GameObject("canvas");
        go.transform.parent = root;
        go.transform.localScale = Vector3.one;

        go.layer = LayerMask.NameToLayer("UI");

        Canvas can = go.AddComponent<Canvas>();
        RectTransform rect = go.GetComponent<RectTransform>();
        rect.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, 0, 0);
        rect.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Top, 0, 0);
        rect.anchorMin = Vector2.zero;
        rect.anchorMax = Vector2.one;

        can.overrideSorting = true;
        can.sortingOrder = sort;

        go.AddComponent<GraphicRaycaster>();

        return go;
    }

    void OnDestroy()
    {
        m_Instance = null;
    }
}