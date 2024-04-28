using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contorlador_de_luces_del_monsturo : MonoBehaviour
{

    public GameObject Monstruo;


    public GameObject Cono_Ariva;
    public GameObject Cono_Abajo;
    public GameObject Cono_Derecha;
    public GameObject Cono_Izquierda;

    public Vector2 _direccionMovimiento;
    public Vector2 _Ultima_diracion;

    public float Posicion_x;
    public float Posicion_y;
    public float Posicion_x_retardado;
    public float Posicion_y_retardado;

    public float Diferencia_x;



    public bool Ariba = false;
    public bool Abajo = false;
    public bool Derecha = false;
    public bool Izquierda = false;


    public bool Oculto=false;





    public float velocidad_Enemigo = 1f;

    public Transform player;
















    [Header("Persecucion")]



    public bool En_persecucion = false;

    public GameObject Luz_de_segimiento;


    public Waypoint Waypoint;

    public WaypointMovimiento WaypointMovimiento;

    public GameObject Set_de_luces;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            En_persecucion = true;





        }
    }


    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {



            En_persecucion = false;


        }
    }










    void Retardo() 
    { 
     Posicion_x_retardado = Posicion_x;
     Posicion_y_retardado = Posicion_y;

        Invoke("Retardo", 0.1f);

    }


    // Start is called before the first frame update
    void Start()
    {
        Invoke("Retardo", 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        //Libro.gameObject.transform.Translate(0, -0.01f, 0);


        //Debug.Log(Monstruo.Translate);
        Posicion_x=GameObject.Find("Monster_1").transform.position.x;
        Posicion_y=GameObject.Find("Monster_1").transform.position.y;



        Diferencia_x = Posicion_x - Posicion_x_retardado;



        if (Posicion_x == Posicion_x_retardado) 
        {

            Derecha = false;
            Izquierda = false;



        }


        if (Diferencia_x > 0) 
        {

              if(Diferencia_x > 0.009f) 
              {

                //Debug.Log("aaaa");
                Derecha = true;
                Izquierda = false;
                Ariba = false;
                Abajo = false;
              }


            if (Diferencia_x < 0.009f)
            {

                //Debug.Log("bbbb");

                Derecha = false;
                Izquierda = false;
                Ariba = false;
                Abajo = true;

            }



        }

        if (Diferencia_x < 0)
        {

            if (Diferencia_x > -0.009f)
            {

                //Debug.Log("dddd");

                Derecha = false;
                Izquierda = false;
                Ariba = true;
                Abajo = false;

            }

            if (Diferencia_x < -0.009f)
            {

                //Debug.Log("cccc");
                Derecha = false;
                Izquierda = true;
                Ariba = false;
                Abajo = false;

            }































        }






       // if (Ariba == true) 
       // { 
       //     Cono_Ariva.SetActive(true);
       //     Cono_Abajo.SetActive(false);
       //     Cono_Derecha.SetActive(false);
       //     Cono_Izquierda.SetActive(false);
       //
       // }


       // if (Abajo == true)
       // {
       //     Cono_Ariva.SetActive(false);
       //     Cono_Abajo.SetActive(true);
       //     Cono_Derecha.SetActive(false);
       //     Cono_Izquierda.SetActive(false);

       // }


       // if (Derecha == true)
       // {
       //     Cono_Ariva.SetActive(false);
       //     Cono_Abajo.SetActive(false);
       //     Cono_Derecha.SetActive(true);
       //     Cono_Izquierda.SetActive(false);

       // }

       // if (Izquierda == true)
       // {
       //     Cono_Ariva.SetActive(false);
       //     Cono_Abajo.SetActive(false);
       //     Cono_Derecha.SetActive(false);
       //     Cono_Izquierda.SetActive(true);

       // }









        if(Oculto != true) 
        {

            if (En_persecucion == true)
            {

                Luz_de_segimiento.SetActive(true);
                Waypoint.enabled = false;
                WaypointMovimiento.enabled = false;

                transform.position = Vector2.MoveTowards(transform.position, new Vector2(player.position.x, player.position.y), velocidad_Enemigo * Time.deltaTime);

                Set_de_luces.SetActive(false);

            }
            else
            {

                Luz_de_segimiento.SetActive(false);
                Waypoint.enabled = true;
                WaypointMovimiento.enabled = true;
                Set_de_luces.SetActive(true);

            }








        }

        
        
        
        
        
        
        



        






    }
}
