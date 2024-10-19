using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gouketsu : MonoBehaviour
{
    public GameObject priyectilPrefab;
    public Transform originProyectil;

    // Start is called before the first frame update
    void Start()
    {
        //invoke();
        InvokeRepeating("Disparar", 1, 2);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void Disparar()
    {
        Instantiate(priyectilPrefab,originProyectil.position,originProyectil.rotation);
    }
}
