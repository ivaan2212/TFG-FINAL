using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Empujar_Mejorrar : MonoBehaviour
{
    public GameObject Caja;
    public bool Colisionando=false;
    public BoxCollider2D Derecha;
    public BoxCollider2D Izquierda;
    public BoxCollider2D Ariba;
    public BoxCollider2D Abajo;


    public bool Empujando_Derecha = false;
    public bool Empujando_Izquierda = false;
    public bool Empujando_Ariba = false;
    public bool Empujando_Abajo = false;





   



    public bool No_Ariva=false;
    public bool No_Abajo = false;
    public bool No_Derecha = false;
    public bool No_Izquierda = false;

    
    

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Colisionando == true) 
        {
            if (No_Izquierda == false)
            {

                if (Empujando_Derecha==true) 
                { 
                
                    if (Input.GetKey(KeyCode.D))
                    {
               
                    Caja.gameObject.transform.Translate( 0.01f, 0, 0 * Time.deltaTime);



                    }
                
                
                
                }

                
            }




            if (No_Derecha == false)
            {

                if (Empujando_Izquierda == true)
                {


                    if (Input.GetKey(KeyCode.A))

                    {
                        Caja.gameObject.transform.Translate(-0.01f, 0, 0 * Time.deltaTime);
                    }


                }
            }

            if (No_Ariva == false)
            {
                if (Empujando_Abajo == true)
                {

                    if (Input.GetKey(KeyCode.S))
                    {


                        Caja.gameObject.transform.Translate(0, -0.01f, 0 * Time.deltaTime);



                    }

                }
            }

            if (No_Abajo == false)
            {

                if (Empujando_Ariba == true)
                {
                    if (Input.GetKey(KeyCode.W))
                    {


                        Caja.gameObject.transform.Translate(0, 0.01f, 0 * Time.deltaTime);

                    }
                }
            }

        }






    }


    
    
  
    
    
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        

        if (other.gameObject.CompareTag("Player"))
        {

            
            Colisionando = true;
        }
    }







    public void OnTriggerExit2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {


            Colisionando = false;
        }




    }






}
