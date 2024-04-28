using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Techo_falso : MonoBehaviour
{


    public GameObject Techo;





    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Techo.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            Techo.SetActive(true);



        }
    }




}
