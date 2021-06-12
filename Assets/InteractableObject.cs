using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour
{
    [SerializeField] private UnityEvent InteractEvent;
    public enum InteractType {once, multiple};
    [SerializeField] private InteractType interactType;
    [SerializeField] private string tagOfPlayer;
    [SerializeField] private bool playerInRange = false;
    [SerializeField] private bool interactable = true;
    [SerializeField] private int maxNumberOfInteractions = 3;
    private int currentInteract = 1;

    public void Interact(){
      if(playerInRange && interactable){
        if(interactType == InteractType.once){
          InteractEventFunction();
          interactable = false;
        }
        else if(interactType == InteractType.multiple){
          InteractEventFunction();
          currentInteract++;
          if(currentInteract > maxNumberOfInteractions) interactable = false;
        }
      }
    }

    private void InteractEventFunction(){
      InteractEvent.Invoke();
    }

    // --- Collisions --------------

    public void OnCollisionEnter(Collision col){
      if(col.gameObject.tag == tagOfPlayer){
        //Debug.Log("The player entered the range");
        playerInRange = true;
      }
    }

    public void OnTriggerEnter(Collider col){
      if(col.gameObject.tag == tagOfPlayer){
        //Debug.Log("The player entered the range");
        playerInRange = true;
      }
    }

    public void OnCollisionExit(Collision col){
      if(col.gameObject.tag == tagOfPlayer){
        //Debug.Log("The player exited the range");
        playerInRange = false;
      }
    }

    public void OnTriggerExit(Collider col){
      if(col.gameObject.tag == tagOfPlayer){
        //Debug.Log("The player exited the range");
        playerInRange = false;
      }
    }
}
