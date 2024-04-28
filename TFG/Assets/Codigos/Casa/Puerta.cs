using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    // Start is called before the first frame update



    public GameObject Puerta_Cerrada;
    public GameObject Puerta_Abierta;
    public bool Bloqueado=false;
    public bool Frente_puerta = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Frente_puerta==true) 
        {
            if (Input.GetKeyDown(KeyCode.E))
            {

                if (Bloqueado == false)
                {
                    Puerta_Cerrada.SetActive(false);
                    Puerta_Abierta.SetActive(true);

                }
            }



        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Frente_puerta = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Frente_puerta = false;




        }
    }















}
