using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    private float horizontal;
    private float vertical;

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
 void Update() 
      {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vetical");



    }
     void FixedUpdate()

    {
        Vector2 position = transform.position;
        position.x = position.x + 3.0f * horizontal * Time.deltaTime;
        position.y = position.x + 3.0f * vertical * Time.deltaTime;
        transform.position = position;
        
    }   
}
