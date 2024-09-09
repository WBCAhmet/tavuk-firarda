using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinUI : MonoBehaviour
{
    private CanvasGroup _canvasGroup;
    public TextMeshProUGUI coinTMP;
    
    public void Show()
    {
        _canvasGroup = GetComponent<CanvasGroup>();
        _canvasGroup.DOFade(1, .2f);
    }

    public void Hide()
    {
        _canvasGroup = GetComponent<CanvasGroup>();
        _canvasGroup.DOFade(0, .2f);
    }

    public void updateCoinCount()
    {
        coinTMP.text = PlayerPrefs.GetInt("CoinCount").ToString();
    }
}
