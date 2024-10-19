using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proyectil : MonoBehaviour
{
    public float velocidadProyectil, tiempoVida;
    public Rigidbody2D rigi;



    void Update()
    {
        rigi.AddForce(Vector2.left * velocidadProyectil);
        Destroy(gameObject, tiempoVida);

    }
    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
          
        }
    }
    ///vamos a hacer cambios
    ///Algo mas nuevo
}
