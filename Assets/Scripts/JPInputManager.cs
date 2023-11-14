using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class JPInputManager : MonoBehaviour
{
    private JPPlayerInput playerInput;
    private JPPlayerInput.OnFootActions onFoot;
    private JPPlayerMotor motor;
    private JPPlayerLook look;
    void Awake()
    {
        playerInput = new JPPlayerInput(); 
        onFoot = playerInput.OnFoot;
        motor = GetComponent<JPPlayerMotor>();
        look = GetComponent<JPPlayerLook>();
        onFoot.Jump.performed += ctx => motor.Jump();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        motor.ProcessMove(onFoot.Movement.ReadValue<Vector2>());
    }

    void LateUpdate()
    {
        look.ProcessLook(onFoot.Look.ReadValue<Vector2>());
    }

    private void OnEnable()
    {
        onFoot.Enable();
    }

    private void OnDisable()
    {
        onFoot.Disable();
    }
}
