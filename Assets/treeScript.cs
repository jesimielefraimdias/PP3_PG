using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeScript : MonoBehaviour
{
    private float speed = 2;
    private float flag = -1;
    private bool scale = false;
    private Vector3 scaleVector;
    // Start is called before the first frame update
    void Start()
    {
        var ls = transform.localScale;
        transform.Translate(0, 0, 40, Space.World);
        //scaleVector = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        float zIndex = transform.position[2];
        
        if(zIndex <= 10){
            flag = 1;
            transform.Rotate(180.0f, 0.0f, 0.0f, Space.World);
            if(scale == false){
                transform.localScale = transform.localScale*(float)0.4;
                scale = true;
            }
        } else if (zIndex >= 40){
            flag = -1;
            transform.Rotate(180.0f, 0.0f, 0.0f, Space.World);
        }
        transform.Translate(0, 0, (flag*Time.deltaTime*speed), Space.World);
    }
}

