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

    }

}
