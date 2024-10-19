using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Objeto que la cámara debe seguir (por ejemplo, el personaje)
    public Transform target;

    // Velocidad de suavizado para el seguimiento de la cámara
    public float smoothSpeed = 0.125f;

    // Offset de la cámara (en este caso, fijamos Z a -10)
    // Offset de la cámara (en este caso, fijamos Z a -10)s
    // Offset de la cámara (en este caso, fijamos Z a -10)
    // Offset de la cámara (en este caso, fijamos Z a -10)
    // Offset de la cámara (en este caso, fijamos Z a -10)
    // Offset de la cámara (en este caso, fijamos Z a -10)
    public Vector3 offset = new Vector3(0f, 0f, -10f);

    void LateUpdate()
    {
        // Verifica si el objetivo (personaje) ha sido asignado
        if (target != null)
        {
            // Calcula la posición deseada con el offset (Z=-10)
            Vector3 desiredPosition = target.position + offset;

            // Interpola suavemente la posición de la cámara hacia la posición deseada
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

            // Asigna la nueva posición a la cámara
            transform.position = smoothedPosition;
        }
    }
}
