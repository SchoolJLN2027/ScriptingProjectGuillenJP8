using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject other;
    // Update is called once per frame
    void Update()
    {
        //DestroyBasic
        if (Input.GetKey(KeyCode.Keypad1))
        {
            Destroy(gameObject);
        }

        //DestroyOther
        if (Input.GetKey(KeyCode.Keypad0))
        {
            Destroy(other);
        }
    }
}
