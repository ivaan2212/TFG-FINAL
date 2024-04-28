using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Codigo_numerico : MonoBehaviour
{

    public TMP_Text Numero1;
    public TMP_Text Numero2;
    public TMP_Text Numero3;
    public TMP_Text Numero4;

    public int N1 = 0;
    public int N2 = 0;
    public int N3 = 0;
    public int N4 = 0;

    public int N1_correcto;
    public int N2_correcto;
    public int N3_correcto;
    public int N4_correcto;

    public bool Correcto=false;
    public GameObject Mensaje_error;


    public void Retorno() 
    {
        Mensaje_error.SetActive(false);

    }


    public void Numero_1_Mas()
    {

        if (N1 != 9) 
        {
            N1++;



        }
        else 
        {
            N1 = 9;
        
        
        }
    }

    public void Numero_1_Menos()
    {
        if (N1 != 0)
        {
            N1--;



        }
        else
        {
            N1 = 0;


        }

    }


    public void Numero_2_Mas()
    {

        if (N2 != 9)
        {
            N2++;



        }
        else
        {
            N2 = 9;


        }
    }

    public void Numero_2_Menos()
    {
        if (N2 != 0)
        {
            N2--;



        }
        else
        {
            N2 = 0;


        }

    }





    public void Numero_3_Mas()
    {
        if (N3 != 9)
        {
            N3++;



        }
        else
        {
            N3 = 9;


        }

    }
    public void Numero_3_Menos()
    {
        if (N3 != 0)
        {
            N3--;



        }
        else
        {
            N3 = 0;


        }

    }


    public void Numero_4_Mas()
    {
        if (N4 != 9)
        {
            N4++;



        }
        else
        {
            N4 = 9;


        }

    }
    public void Numero_4_menos()
    {
        if (N4 != 0)
        {
            N4--;



        }
        else
        {
            N4 = 0;


        }

    }


    public void Comprobante() 
    { 
    
    
        if(N1== N1_correcto) 
        {

            if (N2 == N2_correcto)
            {

                if (N3 == N3_correcto)
                {

                    if (N4 == N4_correcto)
                    {

                        Correcto = true;

                    }
                    else
                    {

                        Mensaje_error.SetActive(true);

                        Invoke("Retorno", 1);


                    }

                }
                else
                {

                    Mensaje_error.SetActive(true);
                    Invoke("Retorno", 1);
                }

            }
            else
            {

                Mensaje_error.SetActive(true);
                Invoke("Retorno", 1);
            }

        }
        else 
        {

            Mensaje_error.SetActive(true);
            Invoke("Retorno", 1);
        }




        //Mensaje_error.SetActive(false);


    }



    // Start is called before the first frame update
    void Start()
    {


        Numero1.text = "0";
        Numero2.text = "0";
        Numero3.text = "0";
        Numero4.text = "0";





    }

    // Update is called once per frame
    void Update()
    {
        #region N1
        if (N1 == 0) 
        {

            Numero1.text = "0";

        }

        if (N1 == 1)
        {

            Numero1.text = "1";

        }

        if (N1 == 2)
        {

            Numero1.text = "2";

        }


        if (N1 == 3)
        {

            Numero1.text = "3";

        }

        if (N1 == 4)
        {

            Numero1.text = "4";

        }

        if (N1 == 5)
        {

            Numero1.text = "5";

        }

        if (N1 == 6)
        {

            Numero1.text = "6";

        }

        if (N1 == 7)
        {

            Numero1.text = "7";

        }

        if (N1 == 8)
        {

            Numero1.text = "8";

        }


        if (N1 == 9)
        {

            Numero1.text = "9";

        }

        #endregion

        #region N2
        if (N2 == 0)
        {

            Numero2.text = "0";

        }

        if (N2 == 1)
        {

            Numero2.text = "1";

        }

        if (N2 == 2)
        {

            Numero2.text = "2";

        }


        if (N2 == 3)
        {

            Numero2.text = "3";

        }

        if (N2 == 4)
        {

            Numero2.text = "4";

        }

        if (N2 == 5)
        {

            Numero2.text = "5";

        }

        if (N2 == 6)
        {

            Numero2.text = "6";

        }

        if (N2 == 7)
        {

            Numero2.text = "7";

        }

        if (N2 == 8)
        {

            Numero2.text = "8";

        }


        if (N2 == 9)
        {

            Numero2.text = "9";

        }

        #endregion

        #region N3
        if (N3 == 0)
        {

            Numero3.text = "0";

        }

        if (N3 == 1)
        {

            Numero3.text = "1";

        }

        if (N3 == 2)
        {

            Numero3.text = "2";

        }


        if (N3 == 3)
        {

            Numero3.text = "3";

        }

        if (N3 == 4)
        {

            Numero3.text = "4";

        }

        if (N3 == 5)
        {

            Numero3.text = "5";

        }

        if (N3 == 6)
        {

            Numero3.text = "6";

        }

        if (N3 == 7)
        {

            Numero3.text = "7";

        }

        if (N3 == 8)
        {

            Numero3.text = "8";

        }


        if (N3 == 9)
        {

            Numero3.text = "9";

        }

        #endregion

        #region N4
        if (N4 == 0)
        {

            Numero4.text = "0";

        }

        if (N4 == 1)
        {

            Numero4.text = "1";

        }

        if (N4 == 2)
        {

            Numero4.text = "2";

        }


        if (N4 == 3)
        {

            Numero4.text = "3";

        }

        if (N4 == 4)
        {

            Numero4.text = "4";

        }

        if (N4 == 5)
        {

            Numero4.text = "5";

        }

        if (N4 == 6)
        {

            Numero4.text = "6";

        }

        if (N4 == 7)
        {

            Numero4.text = "7";

        }

        if (N4 == 8)
        {

            Numero4.text = "8";

        }


        if (N4 == 9)
        {

            Numero4.text = "9";

        }

        #endregion











    }
}
