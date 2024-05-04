using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Telaraña : MonoBehaviour
{



    public PersonajeMovimiento PersonajeMovimiento;



    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {


            PersonajeMovimiento.velocidad = 2f;







        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {


            PersonajeMovimiento.velocidad = 5f;





        }
    }



   
}
