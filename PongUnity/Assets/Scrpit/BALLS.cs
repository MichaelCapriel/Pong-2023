using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BALLS : MonoBehaviour
{
    
    public float movementSpeed;
    public Vector3 direction;
    public float maxXPosition;


    void Update()
    {
        Move();
        CheckBoundries();
    }

    void Move()
    {
        transform.position += direction * movementSpeed * Time.deltaTime;
    }

    public void Bounce(Vector3 newDirection)
    {
        direction = newDirection;
    }

    public void CheckBoundries()
    {
        if(transform.position.x > maxXPosition) 
        {
            ScoreBoard.Instance.GivePointToP1();
            Destroy(gameObject);
        }
        else if (transform.position.x < -maxXPosition)
        {
            ScoreBoard.Instance.GivePointToP2();
            Destroy(gameObject);
        }
    }
    //Hold BALLS and launch at high speed
    //Mirage balls 2 fake and pass through the paddles 1 real
    //Make the ball go invisible power up you can only see the particle system
}
