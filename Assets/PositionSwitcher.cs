using UnityEngine;
using UnityEngine.InputSystem;

public class PositionSwitcher : MonoBehaviour
{
    public Transform roomPosition;
    public Transform externalViewPosition;
    public InputActionReference switchPositionAction;

    private bool isInRoom = true;

    private void OnEnable()
    {
        switchPositionAction.action.Enable();
        switchPositionAction.action.performed += HandleSwitchPosition;
    }

    private void OnDisable()
    {
        switchPositionAction.action.Disable();
        switchPositionAction.action.performed -= HandleSwitchPosition;
    }

    private void HandleSwitchPosition(InputAction.CallbackContext context)
    {
        isInRoom = !isInRoom; 
        transform.position = isInRoom ? roomPosition.position : externalViewPosition.position;
    }
}