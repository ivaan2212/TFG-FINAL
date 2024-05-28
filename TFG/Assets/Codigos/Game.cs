using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public static Game obj;

    public int maxLives = 3;
    public bool gamePaused = false;
    public int score = 0;

    void Awake()
    {
        obj = this;
    }



    void Start()
    {
        //gamePaused = false;

       // UIManager.obj.startGame();
    }

  
   public void addScore(int scoreGive)
    {
      score += scoreGive;
    }

    public void gameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

     void OnDestroy()
     {
      obj = null;
     }
    
}
