using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoopTransition : MonoBehaviour
{
  [SerializeField] private string nameOfNextLoopScene;

  private void LoadNextLoop(){
    SceneManager.LoadScene(nameOfNextLoopScene);
  }

  private void OnCollisionEnter(Collision col){
    LoadNextLoop();
  }
}
