using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverLeft : MonoBehaviour
{
    //Speed for enemies to move
    [SerializeField] private float enemyXSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Force enemy to move the direction left, until it reaches the outer boundary 
        //once reached. Destroy the object off screen.
        transform.Translate(Vector2.left * Time.deltaTime * enemyXSpeed);
        if (transform.position.x < -15)
        {
            Destroy(gameObject);
        }
    }
}
