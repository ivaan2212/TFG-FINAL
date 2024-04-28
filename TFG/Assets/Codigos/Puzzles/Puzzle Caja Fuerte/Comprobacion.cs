using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Comprobacion : MonoBehaviour
{
    /*
        Suponemos que los numeros ya est�n puestos y son los siguientes:
             n1= 1 - - -
             n2= - 5 - -
             n3= - - 8 -
             n4= - - - 3
    */

    //Estos n�meros se quedar�n fijos a no ser que querais que se generen aleatoriamente lo cual es m�s lioso para los sprites que hay que pickear

    private int n1 = 1, n2 = 5, n3 = 8, n4 = 3;
    public TMP_Text t1, t2, t3, t4;
    public GameObject solucion;
    public GameObject error;

    public void Comprobar()
    {
        if( t1.text == n1.ToString() && t2.text == n2.ToString() && t3.text == n3.ToString() && t4.text == n4.ToString())
        {
            solucion.SetActive(true);
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



}
