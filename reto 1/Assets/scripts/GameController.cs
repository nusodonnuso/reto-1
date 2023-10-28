using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour 
{

  public int itemsToWin = 10; 
  public int itemsCollected = 0;
  public GameObject victoryCanvas;

  void OnTriggerEnter(Collider other) 
  {
    if(other.gameObject.CompareTag("Puntos")) 
    {
      itemsCollected++;
      Destroy(other.gameObject);
      
      if(itemsCollected >= itemsToWin) {
        WinGame(); 
      }
    }
  }

  void WinGame() {
    // Código para mostrar pantalla de victoria, etc.
    Debug.Log("¡Has ganado!");
    victoryCanvas.SetActive(true);
  }

}