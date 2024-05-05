using UnityEngine;
using UnityEngine.UI;

public class BotonPanelActivador : MonoBehaviour
{
    public string nombrePanel; // Nombre �nico del panel a activar

    void Start()
    {
        // Agrega un listener al bot�n
        GetComponent<Button>().onClick.AddListener(ActivarPanel);
    }

    void ActivarPanel()
    {
        // Busca el panel por su nombre y lo activa
        GameObject panelParaActivar = GameObject.Find(nombrePanel);
        if (panelParaActivar != null)
        {
            panelParaActivar.SetActive(true);
        }
        else
        {
            Debug.LogError("Panel no encontrado con el nombre: " + nombrePanel);
        }
    }
}