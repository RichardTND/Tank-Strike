using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedShot : MonoBehaviour
{
    [SerializeField] private float timedShot;
    [SerializeField] private GameObject trajectory;
    [SerializeField] private float expiredTime = 500;

    // Start is called before the first frame update
    void Start()
    {
        timedShot = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timedShot = timedShot + 1;
        if (timedShot > expiredTime)
        {
            GameObject.Instantiate(trajectory, transform.position, transform.rotation);
            timedShot = 0;
            expiredTime = Random.Range(300.0f, 700.0f);
        }
    }
}
