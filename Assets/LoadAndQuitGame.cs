using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadAndQuitGame : MonoBehaviour
{
  [SerializeField] private string nameOfFirstSceneToLoad;

  public void StartGame(){
    SceneManager.LoadScene(nameOfFirstSceneToLoad);
  }

  public void QuitGame(){
    Application.Quit();
  }
}
