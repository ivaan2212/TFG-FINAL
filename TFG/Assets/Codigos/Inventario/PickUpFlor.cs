using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpFlor : MonoBehaviour
{
    private InventoryFlor inventory;
    private PickUp pick;
    public GameObject itemPrefab;
    public GameObject textoPrefab;
    private KeyCode teclaRecoger = KeyCode.E;
    private GameObject textoActual;
    public bool Cflor;
    public GameObject Ghosty;
    //public GameObject GhostyOther;
    public GameObject spawn;

    // Start is called before the first frame update
    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<InventoryFlor>();
        itemPrefab.GetComponent<Button>().onClick.AddListener(RecogerObjeto);
        Ghosty = GameObject.FindGameObjectWithTag("Ghosty");
        //GhostyOther = GameObject.FindGameObjectWithTag("GhostyFlor");    
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
        if (Vector2.Distance(transform.position, inventory.transform.position) < 1.5f)
        {
            // Itera a través de los espacios de inventario
            for (int i = 0; i < inventory.slotsFlor.Length; i++)
            {
                // Verifica si el espacio de inventario está vacío
                if (!inventory.isFull[i])
                {
                    if (inventory.slotsFlor[i].transform.childCount > 0)
                    {
                        Destroy(inventory.slotsFlor[i].transform.GetChild(0).gameObject);                        
                    }
                    if (inventory.Panel.transform.childCount > 0)
                    {
                        Destroy(inventory.Panel.transform.GetChild(0).gameObject);
                    }

                    // Marca el espacio de inventario como lleno
                    inventory.isFull[i] = false;

                    // Instancia el objeto recolectable en el espacio de inventario
                    GameObject newItem = Instantiate(itemPrefab, inventory.slotsFlor[i].transform.position, Quaternion.identity, inventory.slotsFlor[i].transform);
                    GameObject textomostrar = Instantiate(textoPrefab, inventory.Panel.transform.position, Quaternion.identity, inventory.Panel.transform);
                    textomostrar.SetActive(false);

                    if (newItem.CompareTag("FlorAutentica"))
                    {
                        Cflor = true;
                        Debug.Log("Es una flor especial");
                        //Ghosty.SetActive(false);
                        //Instantiate(GhostyOther, spawn.transform.position, Quaternion.identity, spawn.transform);
                    }
                    else
                    {
                        Cflor = false;
                        Debug.Log("Es una flor normal");
                        Ghosty.SetActive(true);
                        //GhostyOther.SetActive(false);
                    }

                    // Obtén el componente Button del nuevo objeto
                    Button newItemButton = newItem.GetComponent<Button>();
                    if (newItemButton != null)
                    {
                        // Agrega un listener al evento OnClick del botón
                        newItemButton.onClick.AddListener(() => {                            
                            textomostrar.SetActive(true);
                        });
                     }
                    break;
                }                
            }
        }
    }
}