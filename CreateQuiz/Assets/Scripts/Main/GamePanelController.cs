using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePanelController : MonoBehaviour
{
    [SerializeField] private GameObject quizCardPrefab;
    [SerializeField] private Transform quizCardParent;

    private void Start()
    {
        ShowQuizCard();
    }

    private void ShowQuizCard()
    {

    }
}
