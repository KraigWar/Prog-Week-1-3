using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smoke : MonoBehaviour
{
    public Vector2 start;
    public Vector3 end;
    [Range(0, 1)]
    public float t;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime/2;
        if (t > 1)
        {
            t = 0;
        }
        transform.position = Vector2.Lerp(start, end, t);
    }
}
