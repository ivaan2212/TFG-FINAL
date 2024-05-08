using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerrarAplicacion : MonoBehaviour
{
    // Método para cerrar la aplicación
    public void Cerrar()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Detener la ejecución en el editor de Unity
#else
            Application.Quit(); // Salir de la aplicación en la plataforma de compilación
#endif
    }
}