using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour
{
    public GameObject personaje;
    private bool estaPausado = false; 

    public void PausaActivar()
    {
        Time.timeScale = 0f; 
        estaPausado = true;
        personaje.SetActive(false);
    }


    public void PausaDesactivar()
    {
        Time.timeScale = 1f; 
        estaPausado = false;
        personaje.SetActive(true);
    }

}
