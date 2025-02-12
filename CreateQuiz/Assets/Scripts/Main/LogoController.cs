using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoController : MonoBehaviour
{
    [SerializeField] private RectTransform topLogo;
    [SerializeField] private RectTransform midLogo;
    [SerializeField] private RectTransform botLogo;

    public void Show()
    {
        // 로고 이미지 위치 변경해서 입체적으로 뭐시기..
        topLogo.DOAnchorPosY(15f, 2f);
        botLogo.DOAnchorPosY(-15f, 2f);
    }

    private void Start()
    {
        topLogo.DOAnchorPosY(15f, 2f);
        botLogo.DOAnchorPosY(-15f, 2f);
    }
}
