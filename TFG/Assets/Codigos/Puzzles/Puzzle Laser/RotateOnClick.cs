using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnClick : MonoBehaviour
{
    public float rotationSpeed = 100f; // Velocidad de rotación en grados por segundo
    private bool isDragging = false;

    void Update()
    {
        // Detecta cuando se presiona un botón del mouse
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform == transform)
                {
                    isDragging = true;
                    Debug.Log("Objeto clicado: " + hit.transform.name);
                }
            }
        }

        // Detecta cuando se suelta un botón del mouse
        if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1))
        {
            isDragging = false;
        }

        // Si está arrastrando, rotar el objeto
        if (isDragging)
        {
            if (Input.GetMouseButton(0))
            {
                // Rota el objeto en el sentido horario en el eje Z
                transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
            }
            else if (Input.GetMouseButton(1))
            {
                // Rota el objeto en el sentido antihorario en el eje Z
                transform.Rotate(Vector3.forward, -rotationSpeed * Time.deltaTime);
            }
        }
    }
}