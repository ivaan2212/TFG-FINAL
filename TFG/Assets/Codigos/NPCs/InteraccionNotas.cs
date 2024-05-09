using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteraccionCajaFuerte : MonoBehaviour
{

    public GameObject activador;
    private bool activacion;
    public GameObject canvasActivar;


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
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(activacion && Input.GetKeyDown(KeyCode.E))
        {
            canvasActivar.SetActive(true);
        }
    }
}
