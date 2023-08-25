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
        if(transform.position.x > maxXPosition || transform.position.x < -maxXPosition) 
        {
            BallSpawner.Instance.SpawnBall();
            Destroy(gameObject);
        }
    }

}
