using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smoke : MonoBehaviour
{
    //create a start and an end point variable for the animation
    public Vector2 start;
    public Vector3 end;
    //setting a range value for t to later change its relativity to time adn the curve
    [Range(0, 1)]
    public float t;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        //make t equal to 0.5 seconds each frame
        t += Time.deltaTime/2;
        //Whenerver t goes beyond 1 restart the animation from the begining
        if (t > 1)
        {
            t = 0;
        }
       //transform the position of the object from the start value set to the end value set, then make it over t earlier set to 0.5 seconds each frame
        transform.position = Vector2.Lerp(start, end, t);
    }
}
