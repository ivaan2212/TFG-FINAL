using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpPiedra : MonoBehaviour
{
    private InventoryPiedra inventory;
    public GameObject itemPrefab;
    public GameObject textoPrefab;
    private KeyCode teclaRecoger = KeyCode.E;
    private GameObject textoActual;
    private SoundManager soundmanager;


    private void Awake()
    {
        soundmanager = FindObjectOfType<SoundManager>();
    }

    // Start is called before the first frame update
    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<InventoryPiedra>();
        itemPrefab.GetComponent<Button>().onClick.AddListener(RecogerObjeto);
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
            soundmanager.SeleccionAudio(2, 0.5f);
            // Itera a través de los espacios de inventario
            for (int i = 0; i < inventory.slotsPiedra.Length; i++)
            {
                // Verifica si el espacio de inventario está vacío
                if (!inventory.isFull[i])
                {
                    // Marca el espacio de inventario como ocupado
                    inventory.isFull[i] = true;

                    // Instancia el objeto recolectable en el espacio de inventario
                    GameObject newItem = Instantiate(itemPrefab, inventory.slotsPiedra[i].transform.position, Quaternion.identity, inventory.slotsPiedra[i].transform);
                    GameObject textomostrar = Instantiate(textoPrefab, inventory.Panel.transform.position, Quaternion.identity, inventory.Panel.transform);
                    textomostrar.SetActive(false);

                    // Obtén el componente Button del nuevo objeto
                    Button newItemButton = newItem.GetComponent<Button>();
                    if (newItemButton != null)
                    {
                        // Agrega un listener al evento OnClick del botón
                        newItemButton.onClick.AddListener(() => {
                            // Aquí puedes colocar la lógica que deseas que ocurra cuando se haga clic en el objeto
                            Debug.Log("¡Haz clic en el objeto recolectable!");
                            foreach (Transform child in inventory.Panel.transform)
                            {
                                child.gameObject.SetActive(false);
                            }
                            
                            textomostrar.SetActive(true);
                            Debug.Log("¡Haz 2clic en el objeto recolectable!");
                        });
                     }

                    
                    

                    // Destruye el objeto recolectable del mundo
                    Destroy(gameObject);

                    // Sale del bucle
                    break;
                }
            }
        }
    }
}