using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Cambiarescena : MonoBehaviour
{
    public void CambiarEscena(string EscenaJuego)
    {
        SceneManager.LoadScene(EscenaJuego);
    }
}
