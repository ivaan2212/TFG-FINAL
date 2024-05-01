using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Direcion_De_empuje : MonoBehaviour
{

    public Empujar_Mejorrar Empujar_Mejorrar;



    public bool Derecha = false;
    public bool Izquierda = false;
    public bool Ariba = false;
    public bool Abajo = false;


    public void OnTriggerEnter2D(Collider2D other)
    {


        if (other.gameObject.CompareTag("Player"))
        {

            if (Derecha == true) 
            {
                Empujar_Mejorrar.Colisionando = true;
                Empujar_Mejorrar.Empujando_Derecha = true;

               

            }


            if (Izquierda == true)
            {
                Empujar_Mejorrar.Colisionando = true;
                Empujar_Mejorrar.Empujando_Izquierda = true;


            }

            if (Ariba == true)
            {
                Empujar_Mejorrar.Colisionando = true;
                Empujar_Mejorrar.Empujando_Ariba = true;


            }

            if (Abajo == true)
            {
                Empujar_Mejorrar.Colisionando = true;
                Empujar_Mejorrar.Empujando_Abajo = true;


            }



        }


        
















    }







    public void OnTriggerExit2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {

            if (Derecha == true)
            {

                Empujar_Mejorrar.Colisionando = false;
                Empujar_Mejorrar.Empujando_Derecha = false;



               

            }

            if (Izquierda == true)
            {
                Empujar_Mejorrar.Colisionando = false;
                Empujar_Mejorrar.Empujando_Izquierda = false;


            }

            if (Ariba == true)
            {
                Empujar_Mejorrar.Colisionando = false;
                Empujar_Mejorrar.Empujando_Ariba = false;


            }

            if (Abajo == true)
            {
                Empujar_Mejorrar.Colisionando = false;
                Empujar_Mejorrar.Empujando_Abajo = false;


            }






        }


       





    }










    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
