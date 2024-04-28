using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ayudamario_Optimizado : MonoBehaviour
{
   
 
 

 
     
    
    public Renderer Pepe;







    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Controlador_de_Paredes"))
        {

            Pepe.sortingOrder = -1;



        }





        if (other.CompareTag("Por_delante_Del_armario"))
        {


            Pepe.sortingOrder = 12;





        }





        if (other.CompareTag("Mober_Capa"))
        {


            Pepe.sortingOrder = 10;





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








  