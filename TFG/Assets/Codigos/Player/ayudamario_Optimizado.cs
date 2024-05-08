using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ayudamario_Optimizado : MonoBehaviour
{
   
 
 

 
     
    
    public Renderer Pepe;


    public bool A = false;
    public bool B = false;
    public bool C = false;


    private void OnTriggerEnter2D(Collider2D other)
    {


        if (other.CompareTag("Controlador_de_Paredes"))
        {

            Pepe.sortingOrder = -1;


            A = true;
            B = false;
            C = false;
        }





        if (other.CompareTag("Por_delante_Del_armario"))
        {


            Pepe.sortingOrder = 12;


            A = false;
            B = true;
            C = false;


        }





        if (other.CompareTag("Mober_Capa"))
        {


            Pepe.sortingOrder = 10;

            A = false;
            B = false;
            C = true;



        }

        










    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Controlador_de_Paredes"))
        {
            Pepe.sortingOrder = 4;
        }
    
        if (other.CompareTag("Mober_Capa"))
        {


            Pepe.sortingOrder = 4;





        }


        if (other.CompareTag("Por_delante_Del_armario"))
        {


            Pepe.sortingOrder = 4;





        }





    }












    
    
    

}








  