using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlasdor_de_colisiones : MonoBehaviour
{
    // Start is called before the first frame update


    public GameObject colisiones;




    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Caja"))
        {


            colisiones.SetActive(true);
                







        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Caja"))
        {


            colisiones.SetActive(false);





        }
    }














    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
