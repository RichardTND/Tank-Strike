using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour

{
    public GameObject swoopingBird;
    public Transform spawnPoint;

   
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("player"))

        {

            Instantiate(swoopingBird, spawnPoint.position, spawnPoint.rotation);
            Destroy(gameObject);
            Destroy(transform.parent.gameObject);


        }
    }
}
