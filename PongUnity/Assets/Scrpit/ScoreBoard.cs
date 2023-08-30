using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    public static ScoreBoard Instance;

    int p1Score;
    int p2Score;
    public int maxScore;
    public string winMsg;

    public TextMeshProUGUI p1ScoreText;
    public TextMeshProUGUI p2ScoreText;
    public TextMeshProUGUI winMsgText;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void CheckWin()
    {
            if (p1Score >= maxScore)
            {
                winMsgText.text = "Player 2 is a loser!";
            }
            else if (p2Score >= maxScore)
            {
                winMsgText.text = "Player 1 is a loser!";
            }
            else
            {
                BallSpawner.Instance.SpawnBall();
            }
    }

    public void GivePointToP1()
    {
        p1Score++;
        p1ScoreText.SetText(p1Score.ToString());
        CheckWin();

    }

    public void GivePointToP2()
    {
        p2Score++;
        p2ScoreText.SetText(p2Score.ToString());
        CheckWin();
    }
   
}




