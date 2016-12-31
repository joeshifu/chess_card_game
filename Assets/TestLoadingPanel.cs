using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DG.Tweening;

public class TestLoadingPanel : MonoBehaviour {

    public Slider slider;

	void Start () {
        slider.value = 0f;
        slider.DOValue(1f, 2f, false).SetEase(Ease.Linear);
	}
	
	void Update () {
	
	}

   
}
