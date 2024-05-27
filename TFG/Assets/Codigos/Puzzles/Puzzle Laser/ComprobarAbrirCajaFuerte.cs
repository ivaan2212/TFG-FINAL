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
    public bool Si = false;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            interaccion.SetActive(true);
            
            if (comp.canopen)
            {

                Si = true;
                
            }
        }
    }


    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            interaccion.SetActive(false);
            Si = false;

        }
    }




    void Update()
    {
        if (Si==true) 
        {
            if (Input.GetKeyDown(KeyCode.E))
            {

                cajacerrada.SetActive(false);
                cajaabierta.SetActive(true);
                gema.SetActive(true);

            }
        
        }
    
                   
    
    
    }  






















    }
