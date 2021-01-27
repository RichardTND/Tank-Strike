//Tank Strike - by Philip Bayliss
//programmed by Richard Bayliss in the style of 
//Killer Saucers for the Commodore 64

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float stopZoneLeft;
    [SerializeField] private float stopZoneRight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        TankMover();
    }

    //Tank movement control routine

    void TankMover()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {

            if (transform.position.x < stopZoneLeft)
            {
                Debug.Log("Player has reached stop zone left");
            }
            else
            {
                transform.Translate(Vector2.left * Time.deltaTime * speed);
            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
                if (transform.position.x > stopZoneRight)
                {
                    Debug.Log("Player has reached stop zone right");
                }  else  {

                 transform.Translate(Vector2.right * Time.deltaTime * speed);
                }
        }
    }
}
