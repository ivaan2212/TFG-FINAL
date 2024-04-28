using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCheckController : MonoBehaviour
{
    public GameObject obj;
    public int cant = 1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameObject[] inventario = GameObject.FindGameObjectWithTag("GenerarEventos").GetComponent<InventoryController>().getSlots();

            for (int i = 0; i< inventario.Length; i++)
            {
                if (!inventario[i]) 
                { 
                    GameObject.FindGameObjectWithTag("GenerarEventos").GetComponent<InventoryController>().setSlot(obj, i, cant);
                    Destroy(gameObject);
                    break;
                }
            }

            
        }
    }
}
