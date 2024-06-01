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

    private SoundManager soundmanager;

    private void Awake()
    {
        soundmanager = FindObjectOfType<SoundManager>();
    }
    //public GameObject GhostyOther;

    // Start is called before the first frame update
    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<InventoryFlor>();
        itemPrefab.GetComponent<Button>().onClick.AddListener(RecogerObjeto);
        Ghosty = GameObject.FindGameObjectWithTag("Ghosty");
   
    }

    // Update is called once per frame
    private void Update()
    {

        // Verifica si se presiona la tecla para recoger el objeto
        if (Input.GetKeyDown(teclaRecoger))
        {

            // Recoge el objeto si el jugador est� cerca
            RecogerObjeto();

        }

    }

    private void RecogerObjeto()
    {
        

        // Verifica si el jugador est� cerca del objeto
        if (Vector2.Distance(transform.position, inventory.transform.position) < 1.5f)
        {
            soundmanager.SeleccionAudio(3, 0.5f);
            // Itera a trav�s de los espacios de inventario
            for (int i = 0; i < inventory.slotsFlor.Length; i++)
            {

                // Verifica si el espacio de inventario est� vac�o
                if (!inventory.isFull[i])
                {

                    if (inventory.slotsFlor[i].transform.childCount > 0)
                    {

                        Destroy(inventory.slotsFlor[i].transform.GetChild(0).gameObject);     
                        
                    }

                    // Marca el espacio de inventario como lleno
                    inventory.isFull[i] = false;

                    // Instancia el objeto recolectable en el espacio de inventario
                    GameObject newItem = Instantiate(itemPrefab, inventory.slotsFlor[i].transform.position, Quaternion.identity, inventory.slotsFlor[i].transform);
                    GameObject textomostrar = Instantiate(textoPrefab, inventory.Panel.transform.position, Quaternion.identity, inventory.Panel.transform);
                    textomostrar.SetActive(false);
                    
                    Cflor = false;

                    if (newItem.CompareTag("FlorAutentica"))
                    {
                        Cflor = true;
                        Debug.Log("Es una flor especial");

                    }
                    else
                    {
                        Cflor = false;
                        Debug.Log("Es una flor normal");

                    }

                    // Obt�n el componente Button del nuevo objeto
                    Button newItemButton = newItem.GetComponent<Button>();

                    if (newItemButton != null)
                    {
                        // Agrega un listener al evento OnClick del bot�n
                        newItemButton.onClick.AddListener(() => {

                            foreach (Transform child in inventory.Panel.transform)
                            {

                                child.gameObject.SetActive(false);

                            }

                            textomostrar.SetActive(true);
                        });
                     }
                    break;
                }                
            }
        }
    }
}