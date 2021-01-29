using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingMessage : MonoBehaviour
{
    private float scrollSpeed = 200.0f;
    [SerializeField] private float scrollPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Scrolling message that slides across on the title screen
        transform.Translate(Vector2.left * Time.deltaTime * scrollSpeed);
      
    }
}
