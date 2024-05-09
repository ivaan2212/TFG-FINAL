using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CodigoNumericoIvan : MonoBehaviour
{

    public TMP_Text numero;
    public TMP_Text numero1;
    public TMP_Text numero2;
    public TMP_Text numero3;
    private int aux = 0;
    

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

    public void Arriba1()
    {
        aux = int.Parse(numero1.text);

        if (aux < 9)
        {
            aux++;
        }
        else
        {
            aux = 0;
        }

        numero1.text = aux.ToString();
    }

    public void Abajo1()
    {
        aux = int.Parse(numero1.text);

        if (aux > 0)
        {
            aux--;
        }
        else
        {
            aux = 9;
        }

        numero1.text = aux.ToString();
    }

    public void Arriba2()
    {
        aux = int.Parse(numero2.text);

        if (aux < 9)
        {
            aux++;
        }
        else
        {
            aux = 0;
        }

        numero2.text = aux.ToString();
    }

    public void Abajo2()
    {
        aux = int.Parse(numero2.text);

        if (aux > 0)
        {
            aux--;
        }
        else
        {
            aux = 9;
        }

        numero2.text = aux.ToString();
    }

    public void Arriba3()
    {
        aux = int.Parse(numero3.text);

        if (aux < 9)
        {
            aux++;
        }
        else
        {
            aux = 0;
        }

        numero3.text = aux.ToString();
    }

    public void Abajo3()
    {
        aux = int.Parse(numero3.text);

        if (aux > 0)
        {
            aux--;
        }
        else
        {
            aux = 9;
        }

        numero3.text = aux.ToString();
    }

}
