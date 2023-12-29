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
    List<TMP_Text> scoreTextList = new List<TMP_Text>();
    public GameManager gameManager;

    [SerializeField] BallMovement ballMovement;

    private void Awake()
    {
        p1Score = p2Score = 0;
        scoreList.Add(p1Score);
        scoreList.Add(p2Score);
        scoreTextList.Add(p1ScoreText);
        scoreTextList.Add(p2ScoreText);
    }


    public void PlayerScore(int playerNum)
    {
        scoreList[playerNum]++;
        scoreTextList[playerNum].text = scoreList[playerNum].ToString();
        ballMovement.RestartBall();
        foreach (var item in scoreList)
        {
            if (item != 10) continue;
            gameManager.GameOver((scoreList.IndexOf(item) + 1));
            break;
        }
    }
}
