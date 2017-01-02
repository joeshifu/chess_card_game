using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DG.Tweening;
using XGame.Event;

/// <summary>
/// DownloadPanel,资源下载面板,直接跟包走
/// 1.无需变动,2.在下载时,lua管理器还没初始化,也没法在lua里写逻辑
/// </summary>
public class DownloadPanelScript :MonoBehaviour
{
    public Slider slider;

    private void Awake()
    {
        slider = this.transform.FindChild("Slider").GetComponent<Slider>();
    }
    private void Start()
    {
        EventDispatcher.AddEventListener<float>("DownloadProgress", OnDownloadProgress);
        slider.value = 0f;
    }
    private void OnDestroy()
    {
        EventDispatcher.RemoveEventListener<float>("DownloadProgress", OnDownloadProgress);
    }

    private void OnDownloadProgress(float obj)
    {
        slider.DOValue(obj, 0.5f, false).SetEase(Ease.Linear);
    }

}