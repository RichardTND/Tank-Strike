using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBomb : MonoBehaviour
{
    //Declare speed and position of boundary for enemy bombs 

    [SerializeField] private float speed;
    [SerializeField] private float bottomBoundary;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move bombs downwards, but check if the bomb has reached the bottom boundary 
        //of the game screen, then destroy it.

        transform.Translate(Vector2.down * Time.deltaTime * speed);
        if (transform.position.y < bottomBoundary)
        {
            Destroy(gameObject);
        }
    }
}
