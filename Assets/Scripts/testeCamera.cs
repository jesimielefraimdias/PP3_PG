using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testeCamera : MonoBehaviour
{
    private Camera[] cams;
    private int tamanho;
    // Start is called before the first frame update
    void Start()
    {
        cams = new Camera[Camera.allCamerasCount];
        tamanho = Camera.GetAllCameras(cams);
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown("w"))
        {
            for(int i = 0; i < tamanho; i++)
            {
                cams[i].orthographic = true;
            }
        }
        else if(Input.GetKeyDown("s"))
        {
            for(int i = 0; i < tamanho; i++)
            {
                cams[i].orthographic = false;
            }
        }
    }
}
