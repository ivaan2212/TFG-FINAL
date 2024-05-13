using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MayordomoPaso : MonoBehaviour
{
    public float distanciaDeMovimientoVertical = 1f; // Distancia a mover hacia abajo
    public float velocidad = 0.1f; // Velocidad de movimiento

    public GameObject mayordomo;
    private bool moverVertical = true; // Indica si el NPC está moviéndose verticalmente
    public DetectarObjetosFinal mayor;
    private Animator animator;
    public BoxCollider2D colliderMayor;

    private void Start()
    {
        animator = GetComponent<Animator>();
        colliderMayor = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if (mayor.cambio == true)
        {
            animator.SetBool("Caminar", true);
            if (moverVertical)
            {
                // Mover hacia abajo en cada frame
                transform.Translate(Vector2.down * distanciaDeMovimientoVertical * velocidad * Time.deltaTime);


                if (transform.position.y <= -10) // Cambia esto según la posición en la que quieras cambiar de dirección
                {
                    moverVertical = false; // Cambiar a movimiento horizontal
                    colliderMayor.enabled = false;
                }
            }
        }
       
    }

    
}
