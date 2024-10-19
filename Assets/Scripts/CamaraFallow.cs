using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Objeto que la c�mara debe seguir (por ejemplo, el personaje)
    public Transform target;

    // Velocidad de suavizado para el seguimiento de la c�mara
    public float smoothSpeed = 0.125f;

    // Offset de la c�mara (en este caso, fijamos Z a -10)
    // Offset de la c�mara (en este caso, fijamos Z a -10)s
    // Offset de la c�mara (en este caso, fijamos Z a -10)
    // Offset de la c�mara (en este caso, fijamos Z a -10)
    // Offset de la c�mara (en este caso, fijamos Z a -10)
    // Offset de la c�mara (en este caso, fijamos Z a -10)
    public Vector3 offset = new Vector3(0f, 0f, -10f);

    void LateUpdate()
    {
        // Verifica si el objetivo (personaje) ha sido asignado
        if (target != null)
        {
            // Calcula la posici�n deseada con el offset (Z=-10)
            Vector3 desiredPosition = target.position + offset;

            // Interpola suavemente la posici�n de la c�mara hacia la posici�n deseada
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

            // Asigna la nueva posici�n a la c�mara
            transform.position = smoothedPosition;
        }
    }
}
