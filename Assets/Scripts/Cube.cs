using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private GameObject cilindro;

    // Start is called before the first frame update
    void Start()
    {
        cilindro = GameObject.Find("Cilindro");
        Debug.Log("Text: "+ cilindro.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        float diff = (cilindro.transform.position[2] - transform.position[2]);

        if(diff > 9){
            transform.Translate(0, 0, 1, Space.World);
        } else if(diff < 9){
            transform.Translate(0, 0, -1, Space.World);
        }

        if(Input.GetKeyDown("4") && cilindro.transform.position[0] == -5 && transform.position[0] == -15){
            transform.Translate(10, 0, 0, Space.World);
        } else if(Input.GetKeyDown("6") && cilindro.transform.position[0] == -15 && transform.position[0] == -5){
            transform.Translate(-10, 0, 0, Space.World);
        }
    }
}
