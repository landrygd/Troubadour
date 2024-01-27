using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/CombinaisonDePoses")]
public class Combinaison : ScriptableObject
{
    public bool _rightHand;
    public bool _leftHand;
    public bool _rightLeg;
    public bool _leftLeg;

    public Vector3 _rightHandVector;
    public Vector3 _leftHandVector;
    public Vector3 _rightLegVector;
    public Vector3 _leftLegVector;
}
