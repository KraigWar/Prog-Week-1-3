using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingMouse : MonoBehaviour
{
    public Vector3 mousePos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //grab the mouse position each frame
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //set the z value to 0 to ensure it is visabel in frameve
        mousePos.z = 0;
        //make the position of the object to equal the mouse position that is grabbed every frame
        transform.position = mousePos;
    }
}
