using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cylinderScript : MonoBehaviour
{
    private float speed = 2;
    private float flag = -1;
    private bool scale = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float zIndex = transform.position[2];
        
        if(zIndex <= 3){
            flag = 1;
            transform.Rotate(90.0f, 0.0f, 0.0f, Space.World);
            if(scale == false){
                transform.localScale += (new Vector3(5,5,5));
                scale = true;
            }
        } else if (zIndex >= 25){
            flag = -1;
            transform.Rotate(90.0f, 0.0f, 0.0f, Space.World);
        }
        transform.Translate(0, 0, (flag*Time.deltaTime*speed), Space.World);
    }
}
