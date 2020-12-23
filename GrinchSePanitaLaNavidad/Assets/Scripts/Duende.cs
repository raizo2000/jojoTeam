using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duende : MonoBehaviour
{
    public float Velocidad = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= transform.right * Velocidad * Time.deltaTime;
        transform.Translate(Vector3.left * Time.deltaTime * Velocidad);
    }
}
