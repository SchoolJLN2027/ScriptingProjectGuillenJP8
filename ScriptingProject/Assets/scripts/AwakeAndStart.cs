using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeAndStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start called");
    }

    void Awake()
    {
        Debug.Log("Awake called");
    }
}
