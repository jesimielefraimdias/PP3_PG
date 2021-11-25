using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject cameraPrincipal;

    public GameObject cameraRelogio;

    public GameObject cameraObjetos;

    private Camera[] cams;
    private int tamanho;
    // Start is called before the first frame update
    void Start()
    {
        cams = new Camera[Camera.allCamerasCount];
        tamanho = Camera.GetAllCameras(cams);
        cameraPrincipal.SetActive(true);
        cameraRelogio.SetActive(false);
        cameraObjetos.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("a") && cameraRelogio.activeSelf)
        {
            cameraRelogio.SetActive(false);
            cameraPrincipal.SetActive(true);
        }
        else if(Input.GetKeyDown("a") && cameraPrincipal.activeSelf)
        {
            cameraPrincipal.SetActive(false);
            cameraObjetos.SetActive(true);
        }
        else if(Input.GetKeyDown("a") && cameraObjetos.activeSelf)
        {
            cameraObjetos.SetActive(false);
            cameraRelogio.SetActive(true);
        }
        else if(Input.GetKeyDown("d") && cameraRelogio.activeSelf)
        {
            cameraRelogio.SetActive(false);
            cameraObjetos.SetActive(true);
        }
        else if(Input.GetKeyDown("d") && cameraPrincipal.activeSelf)
        {
            cameraPrincipal.SetActive(false);
            cameraRelogio.SetActive(true);
        }
        else if(Input.GetKeyDown("d") && cameraObjetos.activeSelf)
        {
            cameraObjetos.SetActive(false);
            cameraPrincipal.SetActive(true);
        }
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
        else if(Input.GetKeyDown("up") && cams[0].orthographic == true && cams[0].orthographicSize > 1)
        {
            for(int i = 0; i < tamanho; i++)
            {
                cams[i].orthographicSize -= 1;
            }
        }
        else if(Input.GetKeyDown("down") && cams[0].orthographic == true)
        {
            for(int i = 0; i < tamanho; i++)
            {
                cams[i].orthographicSize += 1;
            }
        }
    }
}
