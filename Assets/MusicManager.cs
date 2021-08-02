using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{

    [SerializeField] private string nameOfSceneToDestroyOn;
    [SerializeField] private List<LevelAndSongParing> LevelAndSongList;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        playAll();
        pauseAll();
    }

    // Update is called once per frame
    void Update(){
      if(SceneManager.GetActiveScene().name == nameOfSceneToDestroyOn) Destroy(gameObject);
      //checkIfSongShouldPlay(SceneManager.GetActiveScene().name);
    }

    void checkIfSongShouldPlay(string currentSceneName){
      foreach(LevelAndSongParing paring in LevelAndSongList){
        if(currentSceneName == paring.NameOfSceneToStartOn){
          pauseAll();
          paring.MusicAudioSource.UnPause();
        }
      }
    }

    void pauseAll(){
      foreach(LevelAndSongParing paring in LevelAndSongList){
        paring.MusicAudioSource.Pause();
      }
    }

    void playAll(){
      foreach(LevelAndSongParing paring in LevelAndSongList){
        paring.MusicAudioSource.Play();
      }
    }
}
