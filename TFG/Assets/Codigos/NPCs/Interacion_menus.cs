using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interacion_menus : MonoBehaviour
{

    /*



   //public BoxCollider2D zona;

    public GameObject mensaje;
    public GameObject Marco_de_texto;
    public bool Mensaje_para_Interactuar=false;
    public GameObject Prefab_del_texto;
    public int texto;
    public bool Mensaje_mostrandose=false;

    // Start is called before the first frame update
    void Start()
    {
       
    }














    // Update is called once per frame
    void Update()
    {


        if(Mensaje_para_Interactuar==true)
        {

          if(Mensaje_mostrandose==false)
          {


            if(Input.GetKeyDown(KeyCode.E))
            {
                                Marco_de_texto.SetActive(true);
                                Instantiate(Prefab_del_texto, Marco_de_texto.transform);

                                Mensaje_mostrandose=true;



            }




          }

        
              
        }
    }








      public void OnTriggerEnter2D(Collider2D other)
  {
      if(other.CompareTag("Player"))
      {

            mensaje.SetActive(true);
            Mensaje_para_Interactuar=true;
          
      
      }
  }

  public void OnTriggerExit2D(Collider2D other)
  {
    if(other.CompareTag("Player"))
    {


          if(texto!=0)
          {


            Destroy(GameObject.Find($"Texto {texto}(Clone)"));
          }
          else
          {
              Destroy(GameObject.Find($"Texto(Clone)"));
          }

           






           
           mensaje.SetActive(false);
           Marco_de_texto.SetActive(false);
           Mensaje_para_Interactuar=false;
           Mensaje_mostrandose=false;
        
    }
    
    
    
    
 }

    */






}
