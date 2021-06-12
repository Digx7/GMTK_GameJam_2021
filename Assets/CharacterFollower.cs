using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFollower : MonoBehaviour
{
    [SerializeField] private List<GameObject> characters;
    [SerializeField] private int currentlySelectedCharacterIndex = 0;
    [SerializeField] private float followSpeed = 100;

    public void LateUpdate(){
      follow();
    }

    private void follow(){
      this.gameObject.transform.position = Vector3.MoveTowards(this.gameObject.transform.position, characters[currentlySelectedCharacterIndex].transform.position, Time.deltaTime * followSpeed);
    }

    public void cycleCharacterSelected(){
      currentlySelectedCharacterIndex++;
      if(currentlySelectedCharacterIndex > characters.Count - 1) currentlySelectedCharacterIndex = 0;
    }

    public void setCurrentlySelectedCharacterIndex(int input){
      if(input > characters.Count - 1) currentlySelectedCharacterIndex = 0;
      else currentlySelectedCharacterIndex = input;
    }
}
