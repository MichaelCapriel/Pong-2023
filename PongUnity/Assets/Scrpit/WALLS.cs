using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WALLS : MonoBehaviour
{
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<BALLS>())
        {
            float ballHitXDirection = collision.gameObject.GetComponent<BALLS>().direction.x;
            float ballHitYDirection = -collision.gameObject.GetComponent<BALLS>().direction.y;

            Vector3 hitDirection = new Vector3(ballHitXDirection, ballHitYDirection, 0);
            collision.gameObject.GetComponent<BALLS>().Bounce(hitDirection);
        }
    }


}
 