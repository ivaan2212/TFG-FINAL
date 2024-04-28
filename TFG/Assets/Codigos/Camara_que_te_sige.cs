using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara_que_te_sige : MonoBehaviour
{


    public Transform jUGADOR;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        float anguloRadianes = Mathf.Atan2(jUGADOR.position.y - transform.position.y, jUGADOR.position.x - transform.position.x);
        float anguloGrados = (180 / Mathf.PI) * anguloRadianes - 90;
        transform.rotation = Quaternion.Euler(0, 0, anguloGrados);



    }
}
