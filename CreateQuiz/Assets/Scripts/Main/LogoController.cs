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
        // �ΰ� �̹��� ��ġ �����ؼ� ��ü������ ���ñ�..
        topLogo.DOAnchorPosY(15f, 2f);
        botLogo.DOAnchorPosY(-15f, 2f);
    }

    private void Start()
    {
        topLogo.DOAnchorPosY(15f, 2f);
        botLogo.DOAnchorPosY(-15f, 2f);
    }
}
