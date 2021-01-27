using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverLeft : MonoBehaviour
{
    [SerializeField] private float enemyXSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * enemyXSpeed);
        if (transform.position.x < -15)
        {
            Destroy(gameObject);
        }
    }
}
