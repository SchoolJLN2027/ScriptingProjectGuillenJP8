using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoWhile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool shouldContinue = false;

        do
        {
            print("hello World");
        }while (shouldContinue == true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
