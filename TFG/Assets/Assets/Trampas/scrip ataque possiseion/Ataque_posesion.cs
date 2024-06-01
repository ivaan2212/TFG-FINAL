using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ataque_posesion : MonoBehaviour
{

    public Transform player;
    public PersonajeMovimiento move;
    private float velocidad_Enemigo = 5;

    private bool areadentro = false;
    private bool Enemigo_ubicado = false;

    private bool cancelar = false;
    public GameObject objeto_poseido;
    public GameObject briyo;

    public CircleCollider2D circulo;
    private SoundManager soundmanager;

    private void Awake()
    {
        soundmanager = FindObjectOfType<SoundManager>();
    }

    public void Auto_destruccion() 
    {
        Destroy(objeto_poseido);        
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Daño"))
        {
            circulo.enabled = false;
            areadentro= true;

            if (briyo != null)
            { 
            
              briyo.SetActive(true);
                Invoke("Auto_destruccion",5f);
            }
        }
    }


    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Daño"))
        {
            areadentro = true;
        }
    }

    public void Retardo() 
    {
        areadentro = false;
        Enemigo_ubicado = true;
        cancelar = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (areadentro) 
        {
            if (cancelar == false) 
            {
                
                Invoke("Retardo", 0.1f);
                float anguloRadianes = Mathf.Atan2(player.position.y - transform.position.y, player.position.x - transform.position.x);
                float anguloGrados = (180 / Mathf.PI) * anguloRadianes - 90;
                transform.rotation = Quaternion.Euler(0, 0, anguloGrados);
            }           
        }

        if (Enemigo_ubicado == true) 
        {
            objeto_poseido.gameObject.transform.Translate(0, velocidad_Enemigo* Time.deltaTime, 0) ;
        } 
    }
}
