using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        // Obtener el componente Animator adjunto al GameObject
        animator = GetComponent<Animator>();
        // Desactivar el Animator al inicio
        animator.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        // Verificar si la colisión es con un objeto llamado "Rota"
        if (other.gameObject.CompareTag("Rota"))
        {
            Debug.Log("Está colisionando");
            // Activar el Animator
            animator.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Verificar si se sale de la colisión con un objeto llamado "Rota"
        if (other.gameObject.CompareTag("Rota"))
        {
            // Desactivar el Animator
            animator.enabled = false;
        }
    }
}