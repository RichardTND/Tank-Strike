using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    [SerializeField] private GameObject playerTank;
    [SerializeField] private GameObject swoopingBird;

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
       
            GameObject.Instantiate(swoopingBird, transform.position, transform.rotation);
            Destroy(gameObject);
       
    }
}
