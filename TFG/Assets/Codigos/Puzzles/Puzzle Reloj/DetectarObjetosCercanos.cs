using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectarObjetosCercanos : MonoBehaviour
{
    public float radius = 1f; // Radio para la detecci�n de objetos cercanos
    public LayerMask layerMask; // Capas a considerar para la detecci�n

    private Animator draggableAnimator;

    void Start()
    {
        draggableAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        // Obtener todos los colliders en un radio alrededor de este objeto
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, radius, layerMask);

        // Verificar si alguno de los objetos cercanos tiene un animator activo
        bool activarAnimator = false;
        Debug.Log(activarAnimator);
        foreach (Collider2D collider in colliders)
        {
            Animator animator = collider.GetComponent<Animator>();
            if (animator != null && animator.enabled)
            {
                activarAnimator = true;
                break;
            }
        }

        // Activar o desactivar el animator seg�n si se detecta un objeto con animator activo
        if (draggableAnimator != null)
        {
            draggableAnimator.enabled = activarAnimator;
        }
    }

    // Dibuja un gizmo para visualizar el �rea de detecci�n en el editor
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}