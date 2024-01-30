using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LightSwitch : MonoBehaviour
{
    public Light light;
    public InputActionReference toggleLightAction;

    private void OnEnable()
    {
        toggleLightAction.action.Enable();
    }

    private void OnDisable()
    {
        toggleLightAction.action.Disable();
    }

    void Start()
    {
        light = GetComponent<Light>();
        toggleLightAction.action.performed += ToggleLight;
    }

    private void ToggleLight(InputAction.CallbackContext context)
    {
        light.color = light.color == Color.white ? Color.red : Color.white;
    }
}