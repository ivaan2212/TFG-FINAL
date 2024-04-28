using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributesController : MonoBehaviour
{
    public int cantidad;

    public void SetCantidad(int nuevacantidad)
    {
        this.cantidad = nuevacantidad;

    }

    public int getCantidad()
    {
        return this.cantidad;
    }
}
