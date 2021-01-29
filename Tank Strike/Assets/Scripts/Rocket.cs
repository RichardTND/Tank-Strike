using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{

    [SerializeField] private float rocketSpeed;
    [SerializeField] private float outerBoundary;
    [SerializeField] private int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
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

    //Collider - bullet should destroy enemies when shot 
    void OnTriggerEnter2D(Collider2D other)
    {


        //Does the rocket hit a bat? ... If so, 100 points gets 
        //awarded ... The reason for 100 points is because the 
        //bats do not shoot anything.  

        if (other.gameObject.CompareTag("enemyBat"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            score = score + 100;
        }

        //Does the rocket hit a bug? ... If so, 200 points gets 
        //awarded

        if (other.gameObject.CompareTag("enemyBug"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            score = score + 200;
        }
        //Does the rocket hit a bird? ... If so, 500 points gets 
        //awarded. As these enemies are fast

        if (other.gameObject.CompareTag("enemyBird"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            score = score + 500;
        }

        if (other.gameObject.CompareTag("divingBird"))
        { 
            Destroy(other.gameObject);
            Destroy(gameObject);
            score = score + 500;
        }
        
    }
    

}
