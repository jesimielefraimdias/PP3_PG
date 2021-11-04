using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    private float speed = 2;
    private float flag = -1;
    private bool scale = false;
    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(0, 0, 40, Space.World);
    }

    // Update is called once per frame
    void Update()
    {
        float zIndex = transform.position[2];
        transform.Translate(0, 0, (flag * Time.deltaTime * speed), Space.World);
    }
}
