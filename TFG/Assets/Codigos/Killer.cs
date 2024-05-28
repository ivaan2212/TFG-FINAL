using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killer : MonoBehaviour
{
   void OnCollisionEnter2D(Collision2D collision)
   {
    if(collision.gameObject.CompareTag("Player"))
    {
        Game.obj.gameOver();
    }
   }
}
