using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDManager : MonoBehaviour
{
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("h") && canvas.activeSelf == false)
        {
            canvas.SetActive(true);
        }
        else if(Input.GetKeyDown("h"))
        {
            canvas.SetActive(false);
        }
    }
}
