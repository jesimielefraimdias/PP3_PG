using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cylinderScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        float zIndex = transform.position[2];
        
        if(Input.GetKeyDown("8"))
        {
            if(transform.position[2] <= 25){
                transform.Translate(0, 0, 1, Space.World);
            }
        }
        else if(Input.GetKeyDown("5"))
        {
            if(transform.position[2] > 12){
                transform.Translate(0, 0, -1, Space.World);
            }
        } 
        else if(Input.GetKeyDown("4")){
            if(transform.position[0] != -15){   
                transform.Translate(-10, 0, 0, Space.World);
            }
        }
        else if(Input.GetKeyDown("6")){
            if(transform.position[0] != -5){   
                transform.Translate(10, 0, 0, Space.World);
            }
        }
    }
}
