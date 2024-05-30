using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarMenuInicial : MonoBehaviour
{
    
    public void CambiarEscenaMenu(string MenuInicial)
    {
        SceneManager.LoadScene(MenuInicial);
    }

}
