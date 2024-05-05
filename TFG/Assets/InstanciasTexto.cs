using UnityEngine;
using UnityEngine.UI;

public class InstanciarTexto : MonoBehaviour
{
    public GameObject textoPrefab; // El prefab del objeto de texto que deseas instanciar
    public Transform referenciaPosicion; // El objeto cuya posición se utilizará como referencia

    // Método que se llama cuando se presiona el botón
    public void OnClick()
    {
        // Verificar si se ha asignado la referencia de posición
        if (referenciaPosicion != null)
        {
            // Instanciar el objeto de texto en la posición de la referencia
            Instantiate(textoPrefab, referenciaPosicion.transform.position, Quaternion.identity);
        }
        else
        {
            Debug.LogError("Referencia de posición no asignada en el botón.");
        }
    }
}