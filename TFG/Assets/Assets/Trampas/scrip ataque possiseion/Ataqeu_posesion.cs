using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ataqeu_posesion : MonoBehaviour
{

    public Transform player;
    public float velocidad_Enemigo = 5;

    private bool Entrasete_en_el_haria = false;
    private bool Enemigo_ubicado = false;

    private bool cancelar = false;
    public GameObject objeto_poseido;
    public GameObject briyo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            Entrasete_en_el_haria = true;


            briyo.SetActive(true);


        }
    }


    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {


            Entrasete_en_el_haria = true;



        }
    }

    public void Retardo() 
    {

        

            Entrasete_en_el_haria = false;

            Enemigo_ubicado = true;




        


    }





    // Update is called once per frame
    void Update()
    {


        if (Entrasete_en_el_haria == true) 
        {



            //persecucion
            //transform.position = Vector2.MoveTowards(transform.position, new Vector2(), velocidad_Enemigo * Time.deltaTime);

            if (cancelar == false) 
            {
                cancelar = true;
                Invoke("Retardo", 1f);
                float anguloRadianes = Mathf.Atan2(player.position.y - transform.position.y, player.position.x - transform.position.x);
                float anguloGrados = (180 / Mathf.PI) * anguloRadianes - 90;
                transform.rotation = Quaternion.Euler(0, 0, anguloGrados);
            }
            
            //rotacion
            
        }

        if (Enemigo_ubicado == true) 
        {






            objeto_poseido.gameObject.transform.Translate(0, 0.04f, 0);



        }
       


    }
}
