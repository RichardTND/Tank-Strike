using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    //Declare private game variables
    [SerializeField]private GameObject player;
    [SerializeField]private GameObject tankStrikeLogo;
    [SerializeField]private GameObject objectSpawnRight;
    [SerializeField]private GameObject objectSpawnLeft;
    [SerializeField]private GameObject titleText;
    [SerializeField]private GameObject gameOverText;
    [SerializeField]private GameObject credits;
    [SerializeField]private GameObject[] enemyPrefabs;
    [SerializeField]private bool isGameOn;

    // Start is called before the first frame update
    void Start()
    {
        isGameOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Check if the game is active. Otherwise objects 
        //selected should be set to false.

        if (!isGameOn)
        {
            //The game is not on, which means all in objects should be removed, unless 
            //the 'Z' key has been pressed to play again.

            player.SetActive (false);
            tankStrikeLogo.SetActive (true);
            objectSpawnRight.SetActive (false);
            objectSpawnLeft.SetActive (false);
            titleText.SetActive (true);
            gameOverText.SetActive(true);
            credits.SetActive (true);
            checkNewGameStart();
            
        } else
        {

            //The key (Z) has been pressed to start a new game. Re-enable the player 
            //and disable all of the title screen objects 

            player.SetActive (true);
            tankStrikeLogo.SetActive (false);
            objectSpawnRight.SetActive (true);
            objectSpawnLeft.SetActive (true);
            titleText.SetActive (false);
            gameOverText.SetActive(false);
            credits.SetActive(false);
           
        }
    }
    void checkNewGameStart()
    {
       if (Input.GetKeyUp(KeyCode.Z))
        {
            isGameOn = true;
        }
    }
}
