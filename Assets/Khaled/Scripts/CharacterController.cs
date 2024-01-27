using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public InputsReader Inputs;

    public GameObject RightHand, LeftHand, RightLeg, LeftLeg;

    private Vector3 _holdRightHand = new(1.5f, 5.66f, 0);
    private Vector3 _holdLeftHand = new(-1.75f, 5.25f, 0);
    private Vector3 _holdRightLeg = new(1.95f, 2.05f, 0);
    private Vector3 _holdLeftLeg = new(-1.86f, 2.46f, 0);

    private Vector3 _idleRightHand = new(0.75f, 2.18f, 0);
    private Vector3 _idleLeftHand = new(-0.82f, 2.13f, 0);
    private Vector3 _idleRightLeg = new(0.46f, 0.11f, 0);
    private Vector3 _idleLeftLeg = new(-0.48f, 0.02f, 0);

    void Update()
    {
        if(Inputs._rightHand == true)
        {
            RightHand.transform.localPosition = _holdRightHand;
        }
        else
        {
            RightHand.transform.localPosition = _idleRightHand;
        }

        if (Inputs._leftHand == true)
        {
            LeftHand.transform.localPosition = _holdLeftHand;
        }
        else
        {
            LeftHand.transform.localPosition = _idleLeftHand;
        }

        if (Inputs._rightLeg == true)
        {
            RightLeg.transform.localPosition = _holdRightLeg;
        }
        else
        {
            RightLeg.transform.localPosition = _idleRightLeg;
        }

        if (Inputs._leftLeg == true)
        {
            LeftLeg.transform.localPosition = _holdLeftLeg;
        }
        else
        {
            LeftLeg.transform.localPosition = _idleLeftLeg;
        }
    }
}
