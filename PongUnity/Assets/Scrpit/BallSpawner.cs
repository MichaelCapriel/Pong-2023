using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using UnityEngine.Rendering;

public class BallSpawner : MonoBehaviour
{
    public static BallSpawner Instance;

    public Transform spawnPosition;
    public GameObject ballPreFab;

    GameObject currentBall;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            SpawnBall();
        }
    }

    public void SpawnBall()
    {
        currentBall = Instantiate(ballPreFab, spawnPosition.position, transform.rotation, null);
        float randX = Random.Range(0, 2) * 2 - 1;
        float randY = Random.Range(-1.5f, 1.5f);
        Vector3 newDrection = new Vector3(randX, randY, 0);
    
        currentBall.GetComponent<BALLS>().direction = newDrection;
    }
    
}
