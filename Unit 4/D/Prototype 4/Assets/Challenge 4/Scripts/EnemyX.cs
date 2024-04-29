using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyX : MonoBehaviour
{
    private float speed = 10;
    private Rigidbody enemyRb;
    public GameObject playerGoal;
    public GameObject spawnManager;
    private int waveCount;
    private float waveSpeed = 1;
    private float finalSpeed;
    private SpawnManagerX spawnManagerX;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        spawnManager = GameObject.Find("Spawn Manager");
        spawnManagerX = spawnManager.GetComponent<SpawnManagerX>();
    }
    // Update is called once per frame
    void Update()
    {
        waveSpeed = spawnManagerX.waveCount * 5;
        finalSpeed = speed * waveSpeed;
        // Set enemy direction towards player goal and move there
        Vector3 lookDirection = (playerGoal.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * finalSpeed * Time.deltaTime);

    }

    private void OnCollisionEnter(Collision other)
    {
        // If enemy collides with either goal, destroy it
        if (other.gameObject.name == "Enemy Goal")
        {
            Destroy(gameObject);
        } 
        else if (other.gameObject.name == "Player Goal")
        {
            Destroy(gameObject);
        }

    }

}
