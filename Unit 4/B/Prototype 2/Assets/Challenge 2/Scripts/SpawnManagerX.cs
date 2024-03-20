using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -15;
    private float spawnLimitXRight = 15;
    private float spawnPosY = 30;
    private float spawnInterval = 4.0f;
    private float startDelay = 1.0f;

    // Start is called before the first frame update
    void Start()
    {   
        //I would like to note that the bonus propts to make the spawn interval random but that isnt possible given the current set up. We would have to change the enitre timing process of spawning the balls.
        spawnInterval = Random.Range(3.0f,5.0f);
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        spawnInterval = Random.Range(1.0f,2.0f);
        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);

    }

}
