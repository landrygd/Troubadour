using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputsReader : MonoBehaviour
{
    public Troubadour _inputs;

    public bool _rightHand, _rightLeg, _leftHand, _leftLeg;

    private void Awake()
    {
        _inputs = new Troubadour();

        /// Start
        _inputs.Player.Right_hand.started += RightHand;
        _inputs.Player.Right_legs.started += RightLeg;
        _inputs.Player.Left_hand.started += LeftHand;
        _inputs.Player.Left_legs.started += LeftLeg;

        /// End
        _inputs.Player.Right_hand.canceled += RightHand;
        _inputs.Player.Right_legs.canceled += RightLeg;
        _inputs.Player.Left_hand.canceled += LeftHand;
        _inputs.Player.Left_legs.canceled += LeftLeg;
    }


    private void OnEnable()
    {
        _inputs.Enable();
    }


    private void OnDisable()
    {
        _inputs.Disable();
    }


    ///     FUNCTIONS 
    
    public void RightHand(InputAction.CallbackContext context)
    {
        _rightHand = context.ReadValueAsButton();
    }

    public void RightLeg(InputAction.CallbackContext context)
    {
        _rightLeg = context.ReadValueAsButton();
    }

    public void LeftHand(InputAction.CallbackContext context)
    {
        _leftHand = context.ReadValueAsButton();
    }

    public void LeftLeg(InputAction.CallbackContext context)
    {
        _leftLeg = context.ReadValueAsButton();
    }
}
