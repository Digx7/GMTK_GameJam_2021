// Digx7
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInputManager : MonoBehaviour {
    /* Description --
    *  This script will handel the player inputs using the new input manager package
    *  This should be what every thing else in the scene refrences when getting the player input
    */

    [SerializeField] private PaperPlayer Player;                  // This references the input action map
    [SerializeField] private bool isOn = true;

    [SerializeField] private Vector2 moveDirection;

    [SerializeField] private Vector2Event moveInput;
    [SerializeField] private UnityEvent InteractInput;
    [SerializeField] private UnityEvent SwapInput;
    [SerializeField] private UnityEvent JumpInput;

    // --- Updates -------------------------------------

    public void Awake() {
        Player = new PaperPlayer();             // This is needed to set up the input action map

        BindInputs();
    }

    // --- Get/Set -------------------------------------

    private void setMoveDirection(Vector2 input){
      moveDirection = input;
      if(isOn) moveInput.Invoke(moveDirection);
      else moveInput.Invoke(new Vector2(0,0));
    }

    public Vector2 getMoveDirection(){
      return moveDirection;
    }

    public bool getIsOn(){
      return isOn;
    }

    public void toggleIsOn(){
      isOn = !isOn;

      if(isOn == false) setMoveDirection(new Vector2(0,0));
    }

    // --- Events -------------------------------------

    private void InteractInputEvent()
    {
        if(isOn)InteractInput.Invoke();
    }
    private void SwapInputEvent()
    {
        if(isOn)SwapInput.Invoke();
    }
    private void JumpInputEvent()
    {
      if(isOn)JumpInput.Invoke();
    }

    // --- BindingInputs ----------------------------------

    // This script will bind the inputs on the Input action map to the needed script
    public void BindInputs() {
        Player.Movement.Move.performed += ctx => setMoveDirection(ctx.ReadValue<Vector2>());
        Player.Movement.Interact.performed += ctx => InteractInputEvent();
        Player.Movement.Swap.performed += ctx => SwapInputEvent();
        Player.Movement.Jump.performed += ctx => JumpInputEvent();
    }

    // --- Enable/Disable --------------------------------

    // This will enable the Input Action Map
    private void OnEnable() {
        Player.Enable();
    }

    // This will enable the Input Action Map
    private void OnDisable() {
        Player.Disable();
    }
}
