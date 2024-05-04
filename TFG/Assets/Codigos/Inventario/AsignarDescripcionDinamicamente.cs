using UnityEngine;
using UnityEngine.UI;

public class AsignarDescripcionDinamicamente : MonoBehaviour
{
    public GameObject prefabBoton; // Prefab del botón que se instancia en el inventario
    public string descripcion; // Descripción del botón

    void Start()
    {
        // Encuentra todos los botones en el canvas de inventario
        Button[] botones = GetComponentsInChildren<Button>();

        // Para cada botón encontrado, asigna la descripción y agrega un listener para el evento de clic
        foreach (Button boton in botones)
        {
            // Crea una referencia al componente BotonConDescripcion y le asigna la descripción
            BotonDescripcion scriptDescripcion = boton.gameObject.AddComponent<BotonDescripcion>();
            scriptDescripcion.descripcion = descripcion;

            // Agrega un listener para el evento de clic que llama al método MostrarDescripcion
            boton.onClick.AddListener(scriptDescripcion.MostrarDescripcion);
        }
    }
}