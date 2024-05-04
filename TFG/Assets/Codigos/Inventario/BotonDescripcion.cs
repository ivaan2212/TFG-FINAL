using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BotonDescripcion : MonoBehaviour
{
    public TMP_Text descripcionText; // Referencia al objeto de texto que mostrar� la descripci�n
    public string descripcion; // Descripci�n del bot�n

    // M�todo llamado cuando el bot�n se pulsa
    public void MostrarDescripcion()
    {
        descripcionText.text = descripcion; // Muestra la descripci�n en el objeto de texto
    }

    // M�todo llamado cuando el puntero se aleja del bot�n (para borrar la descripci�n)
    public void OcultarDescripcion()
    {
        descripcionText.text = ""; // Borra la descripci�n del objeto de texto
    }
}