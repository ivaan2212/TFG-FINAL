using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Comprobacion : MonoBehaviour
{
    /*
        Suponemos que los numeros ya están puestos y son los siguientes:
             n1= 1 - - -
             n2= - 9 - -
             n3= - - 6 -
             n4= - - - 3
    */

    //Estos números se quedarán fijos a no ser que querais que se generen aleatoriamente lo cual es más lioso para los sprites que hay que pickear

    private int n1 = 1, n2 = 9, n3 = 6, n4 = 3;
    public TMP_Text t1, t2, t3, t4;
    public GameObject solucion;
    public GameObject cerrarcanvas;
    public GameObject error;
    public GameObject sprite1;
    public GameObject sprite2;
    public GameObject gema;
    public GameObject llave;
    public InteraccionCanvas caja;


    public void Comprobar()
    {
        if( t1.text == n1.ToString() && t2.text == n2.ToString() && t3.text == n3.ToString() && t4.text == n4.ToString())
        {
            solucion.SetActive(true);
            Invoke("Solucion", 4f);
        }
        else
        {
            error.SetActive(true);
            Invoke("Return", 3f);
            Debug.Log("Error");
        }
    }

    public void Return()
    {
        error.SetActive(false);

        t1.text = "0";
        t2.text = "0";
        t3.text = "0";
        t4.text = "0";

    }


    public void Solucion()
    {
        cerrarcanvas.SetActive(false);
        sprite1.SetActive(false);
        sprite2.SetActive(true);
        gema.SetActive(true);
        llave.SetActive(true);
        caja.GetComponent<BoxCollider2D>().enabled = false;
    }


}
