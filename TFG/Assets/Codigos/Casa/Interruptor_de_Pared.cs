using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interruptor_de_Pared : MonoBehaviour
{
    public GameObject luces;
    public bool off_on = false;
    public bool puedes = false;
    public GameObject verde;
    public GameObject rojo;

    public GameObject[] fantasmas;



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {


            puedes = true;
           


        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            puedes = false;
        
        
        
        
        }
    }





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (puedes == true) 
        { 
        
            if (Input.GetKeyDown(KeyCode.E))
            {

                if (off_on == false)
                {

                    luces.SetActive(true);
                    off_on = true;
                    verde.SetActive(false);
                    rojo.SetActive(true);

                    for (int i = 0; i < fantasmas.Length; i++)
                    {
                        fantasmas[i].SetActive(false);
                    }

                }
                else
                {
                    luces.SetActive(false);
                    off_on = false;
                    verde.SetActive(true);
                    rojo.SetActive(false);
                }




            }
        
        
        }
        








    }
}
