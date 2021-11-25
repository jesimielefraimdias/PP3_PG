using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject cameraPrincipal;

    public GameObject cameraRelogio;

    public GameObject cameraObjetos;
    // Start is called before the first frame update
    void Start()
    {
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
    }
}
