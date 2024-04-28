using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esconderse_armario : MonoBehaviour
{

    public GameObject Puerta_cerrada;
    public GameObject Puerta_abierta;
    public bool Estas_dentro=false;
    public bool cerrado = false;

    public Contorlador_de_luces_del_monsturo Contorlador_de_luces_del_monsturo;




    public void Cierre() 
    {

        Puerta_abierta.SetActive(false);

        Puerta_cerrada.SetActive(true);


    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

           
            
            Estas_dentro=true;

            



        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            Invoke("Cierre", 1);

           

             Estas_dentro=false;



        }
    }
    




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Estas_dentro==true)
        {
           


                if(Input.GetKeyDown(KeyCode.E))
                                        {
                                               if(cerrado==false)
                                               {


                                                cerrado=true;
                                                Puerta_abierta.SetActive(false);

                                                Puerta_cerrada.SetActive(true);

                                                    if (Contorlador_de_luces_del_monsturo != null) 
                                                    { 
                    
                                                        Contorlador_de_luces_del_monsturo.Oculto= true;
                    
                                                    }

                                                

                                               }
                                               else
                                               {
                                                cerrado=false;
                                                Puerta_abierta.SetActive(true);

                                                Puerta_cerrada.SetActive(false);

                                                   
                                                    
                                                    if (Contorlador_de_luces_del_monsturo != null) 
                                                    { 
                    
                                                        Contorlador_de_luces_del_monsturo.Oculto= false;
                    
                                                    }

                                                

                                               }         
                                            
                                        }








            


        }
    }
}
