using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //Game objects for the bats, bugs and birds (can eventually be
    //expanded.
    public GameObject enemyBat, enemyBug, enemyBird;
    public int spawnRate = 5;
    float nextSpawn = 0f;
    int enemyToSpawn;
    public float minY;
    public float maxY;
    public float where;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            enemyToSpawn = Random.Range(1, 4);
            where = Random.Range(minY, maxY);

            switch (enemyToSpawn)
            {
                case 1:
                    Instantiate(enemyBat, new Vector3(transform.position.x, where,-1f), Quaternion.identity);
                    break;
                case 2:
                    Instantiate(enemyBug, new Vector3(transform.position.x, where, -1f), Quaternion.identity);
                    break;
                case 3:
                    Instantiate(enemyBird, new Vector3(transform.position.x, where, -1f), Quaternion.identity);
                    break;
            }

            nextSpawn = Time.time + spawnRate;

        }
    }
}
