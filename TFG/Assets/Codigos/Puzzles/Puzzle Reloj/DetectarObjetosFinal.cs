using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectarObjetosFinal : MonoBehaviour
{
    public float radius = 1f; // Radio para la detección de objetos cercanos
    public LayerMask layerMask; // Capas a considerar para la detección
    public GameObject canvasactivar;
    private float espera = 3f;

    private Animator draggableAnimator;
    private Collider2D myCollider;

    void Start()
    {
        draggableAnimator = GetComponent<Animator>();
        myCollider = GetComponent<Collider2D>(); // Obtener el propio collider
    }

    void Update()
    {
        // Obtener todos los colliders en un radio alrededor de este objeto
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, radius, layerMask);

        // Verificar si alguno de los objetos cercanos tiene un animator activo
        bool activarAnimator = false;

        foreach (Collider2D collider in colliders)
        {
            // Excluir el propio collider del objeto
            if (collider != myCollider)
            {
                Animator animator = collider.GetComponent<Animator>();
                if (animator != null && animator.enabled)
                {
                    activarAnimator = true;
                    break;
                }
            }
        }

        // Activar o desactivar el animator según si se detecta un objeto con animator activo
        if (draggableAnimator != null)
        {
            draggableAnimator.enabled = activarAnimator;
        }
    }

    // Dibuja un gizmo para visualizar el área de detección en el editor
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}