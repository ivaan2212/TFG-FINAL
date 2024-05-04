using UnityEngine;
using UnityEngine.UI;

public class AsignarDescripcionDinamicamente : MonoBehaviour
{
    public GameObject prefabBoton; // Prefab del bot�n que se instancia en el inventario
    public string descripcion; // Descripci�n del bot�n

    void Start()
    {
        // Encuentra todos los botones en el canvas de inventario
        Button[] botones = GetComponentsInChildren<Button>();

        // Para cada bot�n encontrado, asigna la descripci�n y agrega un listener para el evento de clic
        foreach (Button boton in botones)
        {
            // Crea una referencia al componente BotonConDescripcion y le asigna la descripci�n
            BotonDescripcion scriptDescripcion = boton.gameObject.AddComponent<BotonDescripcion>();
            scriptDescripcion.descripcion = descripcion;

            // Agrega un listener para el evento de clic que llama al m�todo MostrarDescripcion
            boton.onClick.AddListener(scriptDescripcion.MostrarDescripcion);
        }
    }
}