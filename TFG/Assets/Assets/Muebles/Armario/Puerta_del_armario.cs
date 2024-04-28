using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta_del_armario : MonoBehaviour
{

     public GameObject Puerta_cerrada;
     public GameObject Puerta_abierta;

    
    public bool Intreactuable=false;





    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

           Intreactuable=true;
            


           



        }
    }


    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

           Intreactuable=false;
            


           



        }
    }








    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Intreactuable==true)
        {


            if(Input.GetKeyDown(KeyCode.E))
                        {
                                            

                            Puerta_abierta.SetActive(true);

                            Puerta_cerrada.SetActive(false);

                        }

            
        }

        
    }
}
