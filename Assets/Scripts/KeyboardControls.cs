using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardControls : MonoBehaviour
{
    public float speed = 5;
    public float rotationSpeed = 50;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 pos = transform.position;
        ////For no smoothing, GetAxisRaw
        //pos.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        //pos.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;

        //transform.position = pos;

        //transform.position.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        transform.Rotate(0, 0, Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime * -1);
        transform.Translate(0, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0);
    }
}
