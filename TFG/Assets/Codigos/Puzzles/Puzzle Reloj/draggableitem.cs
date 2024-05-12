using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class draggableitem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    public Image image;
    [HideInInspector] public Transform ParentAfterDrag;
    //public GameObject[] paneles;

    public void OnBeginDrag(PointerEventData eventData)
    {        
        Debug.Log("Begin drag");
        //transform.localScale = new Vector3(1f, 1f, 1f);
        ParentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        image.raycastTarget = false;
    }
    

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Dragging");
        transform.position = Input.mousePosition;
    }


    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End drag");
        transform.SetParent(ParentAfterDrag);
        image.raycastTarget = true;


    }


}
