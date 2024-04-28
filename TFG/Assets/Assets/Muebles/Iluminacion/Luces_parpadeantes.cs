using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luces_parpadeantes : MonoBehaviour
{

    public GameObject luz;
    public float tiempo_de_encendido = 0.5f;
    public float tiempo_de_apagado = 5f;
    
    
    
    public void Apagar() 
    {
        luz.SetActive(false);
        Invoke("Encender", tiempo_de_encendido);
        
    }

    public void Encender() 
    {
        luz.SetActive(true);
        Invoke("Apagar", tiempo_de_apagado);
    }


    // Start is called before the first frame update
    void Start()
    {
        Invoke("Apagar", tiempo_de_apagado);
    }

    // Update is called once per frame
    void Update()
    {
       
    }






}
