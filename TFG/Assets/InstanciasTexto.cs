using UnityEngine;
using UnityEngine.UI;

public class InstanciarTexto : MonoBehaviour
{
    public GameObject textoPrefab; // El prefab del objeto de texto que deseas instanciar
    public Transform referenciaPosicion; // El objeto cuya posici�n se utilizar� como referencia

    // M�todo que se llama cuando se presiona el bot�n
    public void OnClick()
    {
        // Verificar si se ha asignado la referencia de posici�n
        if (referenciaPosicion != null)
        {
            // Instanciar el objeto de texto en la posici�n de la referencia
            Instantiate(textoPrefab, referenciaPosicion.transform.position, Quaternion.identity);
        }
        else
        {
            Debug.LogError("Referencia de posici�n no asignada en el bot�n.");
        }
    }
}