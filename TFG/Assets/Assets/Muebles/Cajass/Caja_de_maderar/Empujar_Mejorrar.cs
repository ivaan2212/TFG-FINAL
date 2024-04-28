using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Empujar_Mejorrar : MonoBehaviour
{
    public GameObject Caja;
    public bool Colisionando=false;
    public BoxCollider2D Pordonde_empujar;
  
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
                if (Input.GetKey(KeyCode.A))
                {
               
                Caja.gameObject.transform.Translate( -0.01f, 0, 0 * Time.deltaTime);



                }
            }




            if (No_Derecha == false)
            {
                if (Input.GetKey(KeyCode.D))
                {

                    Caja.gameObject.transform.Translate(0.01f, 0, 0 * Time.deltaTime);



                }
            }

            if(No_Ariva == false)
            {


                if (Input.GetKey(KeyCode.W))
                {


                    Caja.gameObject.transform.Translate(0, 0.01f, 0 * Time.deltaTime);



                }
            }

            if (No_Abajo == false)
            {
                if (Input.GetKey(KeyCode.S))
                {


                    Caja.gameObject.transform.Translate(0, -0.01f, 0 * Time.deltaTime);


                }
            }

        }






    }


    void OnCollisionEnter2D(Collision2D collision)
      {
        if (Pordonde_empujar == null) 
        { 
        
            if (collision.gameObject.CompareTag("Player"))
            {

            
                Colisionando = true;
            }
        
        }   

        
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (Pordonde_empujar == null)
        {

            if (collision.gameObject.CompareTag("Player"))
            {


                Colisionando = false;
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
