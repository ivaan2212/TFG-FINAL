using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComprobarCollider : MonoBehaviour
{
    // Referencia pública al BoxCollider del personaje
    public BoxCollider2D boxCollider;

    // Tag de los objetos que activarán el BoxCollider
    public string activateTag = "Activate";

    // Tag de los objetos que desactivarán el BoxCollider
    public string deactivateTag = "Desactivate";

    // Método que se llama cuando otro collider entra en el trigger
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica si el collider tiene la etiqueta para activar
        if (other.CompareTag(activateTag))
        {
            // Activa el BoxCollider
            if (boxCollider != null && !boxCollider.enabled)
            {
                boxCollider.enabled = true;
                Debug.Log("BoxCollider activado.");
            }
        }
        // Verifica si el collider tiene la etiqueta para desactivar
        else if (other.CompareTag(deactivateTag))
        {
            // Desactiva el BoxCollider
            if (boxCollider != null && boxCollider.enabled)
            {
                boxCollider.enabled = false;
                Debug.Log("BoxCollider desactivado.");
            }
        }
    }
}