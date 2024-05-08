using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerrarAplicacion : MonoBehaviour
{
    // M�todo para cerrar la aplicaci�n
    public void Cerrar()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Detener la ejecuci�n en el editor de Unity
#else
            Application.Quit(); // Salir de la aplicaci�n en la plataforma de compilaci�n
#endif
    }
}