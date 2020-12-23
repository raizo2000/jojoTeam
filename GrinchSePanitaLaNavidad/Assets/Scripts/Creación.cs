using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creación : MonoBehaviour
{
    public GameObject Duendes;
    public float tiempo = 1f, rango = 10f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Creando", 0.0f, tiempo);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Creando()
    {
        Vector3 SpawnPosition = new Vector3(0, 0, 0);
        SpawnPosition = this.transform.position + Random.onUnitSphere * rango;
        SpawnPosition = new Vector3(SpawnPosition.x, SpawnPosition.y, 0);

        GameObject Duende = Instantiate(Duendes, SpawnPosition, Quaternion.identity);
    }
}
