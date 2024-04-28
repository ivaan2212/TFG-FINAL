using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CodigoNumericoIvan : MonoBehaviour
{

    public TMP_Text numero;
    private int aux=0;
    public GameObject mensaje_error;

    public void Arriba()
    {
        aux = int.Parse(numero.text);

        if (aux < 9)
        {
            aux++;
        }
        else
        {
            aux = 0;
        }

        numero.text = aux.ToString();
    }

    public void Abajo()
    {
        aux = int.Parse(numero.text);

        if (aux > 0)
        {
            aux--;
        }
        else
        {
            aux = 9;
        }

        numero.text = aux.ToString();
    }

}
