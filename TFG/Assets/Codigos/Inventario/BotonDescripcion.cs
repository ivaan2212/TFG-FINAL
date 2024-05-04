using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BotonDescripcion : MonoBehaviour
{
    public TMP_Text descripcionText; // Referencia al objeto de texto que mostrará la descripción
    public string descripcion; // Descripción del botón

    // Método llamado cuando el botón se pulsa
    public void MostrarDescripcion()
    {
        descripcionText.text = descripcion; // Muestra la descripción en el objeto de texto
    }

    // Método llamado cuando el puntero se aleja del botón (para borrar la descripción)
    public void OcultarDescripcion()
    {
        descripcionText.text = ""; // Borra la descripción del objeto de texto
    }
}