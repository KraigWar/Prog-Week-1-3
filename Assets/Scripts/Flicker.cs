using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Flicker : MonoBehaviour
{
    //initializing the curve needed to set within the sceen
    public AnimationCurve slowCurve;
    //setting a range value for t to later make it 1 second
    [Range(0,1)]
        public float t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //make t scale with each frame
        t += Time.deltaTime;
        //iff statement that restarts t to 0 everytime it reaches 1 (second) to continue the animation
        if (t > 1)
        {
            t = 0;
        }
        //set the local scale of x and y to the curve at time t
        transform.localScale = Vector2.one * slowCurve.Evaluate(t);
    }
}
