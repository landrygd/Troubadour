using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskedObject : MonoBehaviour
{
    public GameObject[] maskedObjects;

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject obj in maskedObjects)
        {
            obj.GetComponent<Renderer>().material.renderQueue = 3002;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
