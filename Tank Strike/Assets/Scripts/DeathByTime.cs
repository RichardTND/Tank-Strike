using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathByTime : MonoBehaviour
{
    private int deathAnimWaitTime;
    // Start is called before the first frame update
    void Start()
    {
        deathAnimWaitTime = 0;       
    }

    // Update is called once per frame
    void Update()
    {
        //After the player has been destroyed give it time before GAME OVER

        deathAnimWaitTime = deathAnimWaitTime + 1; //Integer of 1 to death animation
        Debug.Log(deathAnimWaitTime);
        if (deathAnimWaitTime > 200)
        {
            Destroy(gameObject);
            
        }
    }

}
