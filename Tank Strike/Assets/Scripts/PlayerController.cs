//Tank Strike - by Philip Bayliss
//programmed by Richard Bayliss in the style of 
//Killer Saucers for the Commodore 64

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Setup variables for the player controller
    [SerializeField] private float speed;
    [SerializeField] private float stopZoneLeft;
    [SerializeField] private float stopZoneRight;
    [SerializeField] private float timedShot;
    [SerializeField] private float timeExpiry;
    [SerializeField] private GameObject missile;
    [SerializeField] private GameObject playerExplosion;
    // Start is called before the first frame update
    void Start()
    {
        timedShot = 0.0f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Move tank around. Also time the shot
        TankMover();
        timedShot = timedShot + 1;

        //Once the timedShot has reached the expiry time,
        //allow the player to fire a new bullet after pressing
        //'Z' on the keyboard.

        if (timedShot > timeExpiry)
        {
            
            TankBlaster();
        }
    }

    //Tank movement control routine

    void TankMover()
    {
        //Press LEFT Arrow on keyboard to move tank LEFT
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Check if transform position limit has been reached
            //if so, ignore movement
            if (transform.position.x < stopZoneLeft)
            {
               
            }
            else
            {   //Allow the player to move LEFT
                transform.Translate(Vector2.left * Time.deltaTime * speed);
            }
        }
        //Press RIGHT Arrow on keyboard to move tank RIGHT
        if (Input.GetKey(KeyCode.RightArrow))
        {

            //Check if transform position limit has been reached
            //of so,  ignore movement
            if (transform.position.x > stopZoneRight)
                {
            
                }  else  {
                //Allow the player to move RIGHT
                 transform.Translate(Vector2.right * Time.deltaTime * speed);
                }
        }
    }

    //Tank shooting 
    void TankBlaster()
    {
        //The timer was set to allow the player shoot its rocket. Allow press of Key Z
        //to fire the shot.
        if (Input.GetKey(KeyCode.Z))
        {
            GameObject.Instantiate(missile, transform.position, transform.rotation);
            timedShot = 0;
        }
    }

    //Player to ENEMY BULLET or SWOOPING BIRD collision.
    void OnTriggerEnter2D(Collider2D enemy)
    {
        //Check if the player has been hit by an enemy bullet. If it hits
        //the player, the player is dead.
        if (enemy.gameObject.tag == "enemyBullet")
        {
            playerIsDead();

        }

        //Check if the player has been hit by a swooping bird. If it hits 
        //the player, the player is dead.
        if (enemy.gameObject.tag == "divingBird") 
        {
            playerIsDead();
        }
    }
 
    //Player death sequence. Basically instantiate the explosion and then
    //disable the player object.

    void playerIsDead()
    {
        GameObject.Instantiate(playerExplosion, transform.position, transform.rotation);
        

    }
}

 