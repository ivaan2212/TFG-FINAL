using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemPrefab;
    public KeyCode teclaRecoger = KeyCode.J;

    // Start is called before the first frame update
    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    // Update is called once per frame
    private void Update()
    {
        // Verifica si se presiona la tecla para recoger el objeto
        if (Input.GetKeyDown(teclaRecoger))
        {
            // Recoge el objeto si el jugador está cerca
            RecogerObjeto();
        }
    }

    private void RecogerObjeto()
    {
        // Verifica si el jugador está cerca del objeto
        if (Vector2.Distance(transform.position, inventory.transform.position) < 1.3f)
        {
            // Itera a través de los espacios de inventario
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                // Verifica si el espacio de inventario está vacío
                if (!inventory.isFull[i])
                {
                    // Marca el espacio de inventario como ocupado
                    inventory.isFull[i] = true;

                    // Instancia el objeto recolectable en el espacio de inventario
                    Instantiate(itemPrefab, inventory.slots[i].transform.position, Quaternion.identity, inventory.slots[i].transform);

                    // Destruye el objeto recolectable del mundo
                    Destroy(gameObject);

                    // Sale del bucle
                    break;
                }
            }
        }


    }
}