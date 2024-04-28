using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryController : MonoBehaviour
{
    public GameObject[] slots;
    Text text;

    private int num_slots_max = 7;

    // Start is called before the first frame update
    void Start()
    {
        slots = new GameObject[num_slots_max];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public GameObject[] getSlots()
    {
        return this.slots;
    }

    public void setSlot(GameObject slot, int pos, int cant)
    {
        bool exist = false;

        for (int i = 0; i<slots.Length; i++)
        {
            if(slots[i] != null)
            {
                if (slots[i].tag == slot.tag)
                {
                    int already_cant = slots[i].GetComponent<AttributesController>().getCantidad();
                    this.slots[i].GetComponent<AttributesController>().SetCantidad(already_cant + cant);
                    exist = true;
                }
            }
        }

        if (!exist)
        {
            slot.GetComponent<AttributesController>().SetCantidad(cant);
            this.slots[pos] = slot;
        }
    }

    public void showInventory()
    {
        Component[] inventario = GameObject.FindGameObjectWithTag("inventario").GetComponentsInChildren<Transform>();
        bool slotUsed = false;

        if (removeitems(inventario))
        {
            for (int i = 0; i< slots.Length; i++)
            {
                if (slots[i] != null)
                {
                    slotUsed = false;

                    for (int e = 0; e<inventario.Length; e++)
                    {
                        GameObject child = inventario[e].gameObject;

                        if (child.tag == "slot" && child.transform.childCount <=1 && !slotUsed)
                        {
                            GameObject item = Instantiate(slots[i],child.transform.position, Quaternion.identity);
                            item.transform.SetParent(child.transform, false);
                            item.transform.localPosition = new Vector3(0, 0, 0);
                            item.name = item.name.Replace("Clone", "");
                            text = item.GetComponentInChildren<Text>();
                            int cant = 1;
                            text.text = cant + "";

                            slotUsed = true;
                        }
                    }
                }
            }
        }
    }

    public bool removeitems(Component[] inventario)
    {
        bool itemsRemoved = false;
        for ( int e = 1; e<inventario.Length; e++)
        {
            GameObject child = inventario[e].gameObject;

            if (child.tag == "slot" && child.transform.childCount > 0)
            {
                for (int a = 0; a <= 0; a++)
                {
                    Destroy(child.transform.GetChild(a).transform.gameObject);
                }
            }
        }

        return itemsRemoved;
    }

    
}
