using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacaoRelogio : MonoBehaviour
{
    private float count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0f;
    }
    
    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime; //adiciona deltaTime a cada quadro. Intervalo de tempo entre um Update e outro
        count = count % 360f;
        float x = Mathf.Cos(count); 
        float y = Mathf.Sin(count);

        transform.position += new Vector3(x * 0.01f, y * 0.01f, 0);
    }
}
