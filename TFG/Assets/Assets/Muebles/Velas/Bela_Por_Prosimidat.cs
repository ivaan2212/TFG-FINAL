using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bela_Por_Prosimidat : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject luz;




    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            luz.SetActive(true);


        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {


            luz.SetActive(false);

        }

    }











}
