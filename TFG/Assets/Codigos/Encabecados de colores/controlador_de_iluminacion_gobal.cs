using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlador_de_iluminacion_gobal : MonoBehaviour
{

    public GameObject luz;
    public GameObject luz_apagada;

    // Start is called before the first frame update
    void Start()
    {
        luz_apagada.SetActive(false);
        luz.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
