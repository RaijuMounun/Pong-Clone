using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] TMP_Text gameOverText;
    [SerializeField] List<GameObject> CanvasList = new List<GameObject>();

    private void Awake()
    {
        CanvasList[0].SetActive(true);
        CanvasList[1].SetActive(false);
    }

    public void GameOver(int playerNum)
    {
        CanvasList[0].SetActive(false);
        CanvasList[1].SetActive(true);



        gameOverText.text = $"Player {playerNum} Wins!";
    }
}
