using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detecion_Player : MonoBehaviour
{

    public int contado = 0;

    public CircleCollider2D circulo;
    public WaypointMovimiento _waypoint_1;
    public WaypointMovimiento _waypoint_2;
    public WaypointMovimiento _waypoint_3;

    public GameObject Primer_objeto;
    public GameObject Segundo_objeto;
    public GameObject Tercero_objeto;

    public bool Cero_uno = false;
    public bool Cero_dos = false;
    public bool Cero_tres = false;








    void Momento_1()
    {

        Primer_objeto.SetActive(false);
        Segundo_objeto.SetActive(true);

    }

    void Momento_2()
    {

        
        Segundo_objeto.SetActive(false);
        Tercero_objeto.SetActive(true);

    }

    void Momento_3()
    {
        Tercero_objeto.SetActive(false);
        Primer_objeto.SetActive(true);


    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_waypoint_1.contador == 0) 
        {

            if (Cero_uno == false) 
            {

                Invoke("Momento_1", 1);


            }



            Cero_uno = true;
            
        }
    
        if (_waypoint_1.contador == 1) 
        {
            Cero_uno = false;
        
        
        }






        if (_waypoint_2.contador == 0)
        {

            if (Cero_dos == false)
            {

                Invoke("Momento_2", 1);


            }



            Cero_dos = true;

        }

        if (_waypoint_2.contador == 1)
        {
            Cero_dos = false;


        }






        if (_waypoint_3.contador == 0)
        {

            if (Cero_tres == false)
            {

                Invoke("Momento_3", 1);


            }



            Cero_tres = true;

        }

        if (_waypoint_3.contador == 1)
        {
            Cero_tres = false;


        }
























    }
}
