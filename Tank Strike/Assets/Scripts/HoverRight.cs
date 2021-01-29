using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverRight : MonoBehaviour
{
    [SerializeField] private float enemyXSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Force enemy to move the direction right, until it reaches the outer boundary 
        //once reached. Destroy the object off screen.
        transform.Translate(Vector2.right * Time.deltaTime * enemyXSpeed);
        if (transform.position.x > 14)
        {
            Destroy(gameObject);
        }
    }
}
