using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GymJumping : MonoBehaviour
{
    public bool jump;

    public AnimationCurve curve;



    [Range(0, 1)]
    public float t;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        t += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            t = 0;
            
        }
         if (t < 1)
         {
            Vector2 pos = transform.position;

            pos.y = curve.Evaluate(t);
           
            transform.position = pos;

           Vector3 rot = transform.eulerAngles;

            rot.z = curve.Evaluate(t);

            transform.eulerAngles = rot;

        }
        
            
        
    }


}


    