using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OcultarBoton : MonoBehaviour
{
    private GameObject laser;


    private void Update()
    {
        Ocultar();
    }

    public void Ocultar()
    {
        laser = GameObject.Find("LaserBeam");
        laser.SetActive(false);
    }
}
