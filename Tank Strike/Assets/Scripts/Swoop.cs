using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swoop : MonoBehaviour
{

    [SerializeField]private float swoopVelocity = 20;
    [SerializeField] private float BoundaryPosition = -10;
    
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Bird enemy (which was instantiated into this new version) sets to charge towards
        //the ground. Once it leaves the screen, it should be destroyed.

        if (transform.position.y < BoundaryPosition)
        
        {

            Destroy(gameObject);
        }
        transform.Translate(Vector2.down * Time.deltaTime * swoopVelocity);
    }
}
