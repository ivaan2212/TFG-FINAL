using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CambioColor : MonoBehaviour
{
    public SpriteRenderer jugador;
    public PersonajeMovimiento move;
    public Color nuevoColor; // Color al que cambiará el jugador
    private Color original;
    public BoxCollider2D colliderobjeto;
    public Collider2D colliderJugadorEspecifico; // El collider específico del jugador con el que debe colisionar colliderobjeto

    private void Start()
    {
        original = jugador.color;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica si colliderobjeto colisiona con el collider específico del jugador
        if (other == colliderJugadorEspecifico && colliderobjeto.IsTouching(colliderJugadorEspecifico))
        {
            move.velocidad = 0f;
            jugador.color = nuevoColor;
        }
    }

    void OnTriggerExit2D(Collider2D colision)
    {
        // Verifica si colliderobjeto deja de colisionar con el collider específico del jugador
        if (colision == colliderJugadorEspecifico && !colliderobjeto.IsTouching(colliderJugadorEspecifico))
        {
            move.velocidad = 5f;
            jugador.color = original;
        }
    }
}