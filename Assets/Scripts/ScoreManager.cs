using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] int p1Score, p2Score;
    List<int> scoreList = new List<int>();
    [SerializeField] TMP_Text p1ScoreText, p2ScoreText;

    private void Awake()
    {
        p1Score = p2Score = 0;
        scoreList.Add(p1Score);
        scoreList.Add(p2Score);
    }


    private void PlayerScore(int playerNum)
    {

    }
}
