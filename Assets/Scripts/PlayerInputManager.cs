using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerInputManager : MonoBehaviour
{
    private InputAction Movement;
    private InputAction Interact;
    private InputAction Throw;
    public PlayerControlsC PlayerControls;
    public CharacterController characterController;
    public Vector2 InputVector = Vector2.zero;
    public Vector3 MovementVector = Vector3.zero;
    public Vector2 AimVector = Vector2.zero;
    public float speeeeed = 0.5f;
    public float gravity = -0.1f;
    // Start is called before the first frame update
    void Start()
    {
        PlayerControls = new PlayerControlsC();
    }

    // Update is called once per frame
    void Update()
    {
        if (InputVector.x != 0.0f || InputVector.y != 0.0f)
        {
            AimVector = InputVector;
        }
        MovementVector = new Vector3(InputVector.x * speeeeed, gravity, InputVector.y * speeeeed);
        characterController.Move(MovementVector);
    }
    public void onMove(InputAction.CallbackContext context)
    {
        Debug.Log("moving");
        InputVector = context.ReadValue<Vector2>();
    }
    public void onInteract(InputAction.CallbackContext context)
    {

    }
    public void onThrow(InputAction.CallbackContext context)
    {
        Debug.Log("scripts");

    }
}
