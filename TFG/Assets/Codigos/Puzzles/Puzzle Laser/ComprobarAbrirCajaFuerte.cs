using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComprobarAbrirCajaFuerte : MonoBehaviour
{
    public RaycastReflection comp;
    public GameObject interaccion;
    public GameObject cajaabierta;
    public GameObject cajacerrada;
    public GameObject gema;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            interaccion.SetActive(true);

            if (comp.canopen)
            {
                cajacerrada.SetActive(false);
                cajaabierta.SetActive(true);
                gema.SetActive(true);
            }
        }
    }


    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            interaccion.SetActive(false);
        }
    }



}
