using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{

    [SerializeField] private float rocketSpeed;
    [SerializeField] private float outerBoundary;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Force player rocket to shoot upwards ... If the rocket reaches outside
        //of the game screen, destroy it.

        transform.Translate(Vector2.up * Time.deltaTime * rocketSpeed);

        if (transform.position.y > outerBoundary)
        {
            Destroy(gameObject);
        }
        

    }
}
