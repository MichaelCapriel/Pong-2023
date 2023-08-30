using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAI : MonoBehaviour
{
    public Paddle paddle;
    BALLS currentBall;
    public float distanceBuffer;

    void Start()
    {
        
    }

    void Update()
    {
        if (currentBall == null)
        {
            FindBall();
        }
        else
        {
            FollowBall();
        }
    }   
       
    void TrashTalk()
    {
        Debug.Log("Trash, EZ,'GG' ");
    }

    void FindBall()
    {
      
            currentBall = FindAnyObjectByType<BALLS>();
    }

    void FollowBall()
    {
        if (currentBall.transform.position.y > paddle.transform.position.y + distanceBuffer) 
        {
            paddle.MoveUp();
        }
        else if (currentBall.transform.position.y < paddle.transform.position.y + distanceBuffer)
        {
            paddle.MoveDown();
        }

    }
}
