using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteraccionCanvas : MonoBehaviour
{

    public GameObject activador;
    private bool activacion;
    public GameObject canvasActivar;
    public GameObject pausapanel;


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")){
            activador.SetActive(true);
            activacion = true;            
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")){
            activador.SetActive(false);
            activacion = false;
            pausapanel.SetActive(true);
        }
    }


    // Update is called once per frame
    void Update()
    {
        

        if(activacion && Input.GetKeyDown(KeyCode.E))
        {
            pausapanel.SetActive(false);
            canvasActivar.SetActive(true);

        }
        
    }

}
