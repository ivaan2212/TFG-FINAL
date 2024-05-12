using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PanelEngranaje : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            GameObject dropped = eventData.pointerDrag;
            draggableitem draggableitem = dropped.GetComponent<draggableitem>();
            draggableitem.ParentAfterDrag = transform;
        }
    }

}
