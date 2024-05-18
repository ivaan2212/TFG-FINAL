using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // Velocidad de movimiento del jugador

    private Rigidbody2D rb; // Referencia al componente Rigidbody2D
    private Vector2 movementDirection = Vector2.zero; // Dirección de movimiento actual

    void Start()
    {
        // Obtener la referencia al componente Rigidbody2D
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Si no está en movimiento, obtener la entrada de teclado horizontal y vertical
        if (movementDirection == Vector2.zero)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            // Si hay una nueva entrada de movimiento, actualizar la dirección
            if (moveHorizontal != 0 || moveVertical != 0)
            {
                movementDirection = new Vector2(moveHorizontal, moveVertical).normalized;
            }
        }

        // Aplicar el movimiento al Rigidbody2D
        rb.velocity = movementDirection * speed;
    }

    // Detectar colisiones con otros colliders
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Detener el movimiento si se colisiona con otro objeto
        movementDirection = Vector2.zero;
    }
}