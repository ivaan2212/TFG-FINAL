using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Codigodelibortrampa : MonoBehaviour
{
    public GameObject Libro;
    public GameObject revorde;
    public bool auto_destrupcion = false;
    public bool En_mobimiento = false;
    public int temporizador=5;

    void Inicio() 
    {

        auto_destrupcion = true;
    
    
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(En_mobimiento==true)
        {
            Libro.gameObject.transform.Translate(0, -0.01f, 0);


        }

        if (auto_destrupcion == true)
        {
            Destroy(Libro);

        }



    }





    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            revorde.SetActive(true);
            En_mobimiento = true;


            Invoke("Inicio", temporizador);


        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {



            auto_destrupcion = true;




        }
    }

























}
