using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador_De_sprites_Caja : MonoBehaviour
{

    public Renderer Cara_superior;



    private void OnTriggerEnter2D(Collider2D other)
    {


        if (other.CompareTag("Player"))
        {

           Cara_superior.sortingOrder =3;
        }









    }


    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Cara_superior.sortingOrder = 9;
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
