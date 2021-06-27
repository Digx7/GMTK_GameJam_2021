using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompanionFollower : MonoBehaviour
{
    [SerializeField] private bool isOn = false;
    [SerializeField] private GameObject companion;
    [SerializeField] private PlayerMovement ownMovement;
    [SerializeField] private Vector2 companionDirection;
    [SerializeField] private Vector2 minAndMaxFollowDistance;
    [SerializeField] private float companionDistance;
    private Vector2 movementStopCommand;

    public void ToggleIsOn(){
      isOn = !isOn;
    }

    public void setIsOn(bool input){
      isOn = input;
    }

    public void setMinFollowDistance(float input){
      minAndMaxFollowDistance.x = input;
    }

    public void FixedUpdate(){
      directionOfCompanion();
      distanceOfCompanion();
      if(isOn){
        if(isInRangeToFollow()) StartFollowing();
        else StopFollowing();
      }
    }

    private void directionOfCompanion(){
      if(companion.transform.position.x > ownMovement.gameObject.transform.position.x) // companion is to the right
      {
        companionDirection.x = 1;
      }
      else
      {
        companionDirection.x = -1;
      }
    }

    private void distanceOfCompanion(){
      //companionDistance = Vector3.Distance (object1.transform.position, object2.transform.position);
      companionDistance = Mathf.Abs(companion.transform.position.x - ownMovement.gameObject.transform.position.x);
    }

    private bool isInRangeToFollow(){
      if(companionDistance > minAndMaxFollowDistance.y) return false;
      else if(companionDistance < minAndMaxFollowDistance.x) return false;
      else return true;
    }

    private void StartFollowing(){
      ownMovement.setMovementInput(companionDirection);
    }

    private void StopFollowing(){
      ownMovement.setMovementInput(movementStopCommand);
    }

}
