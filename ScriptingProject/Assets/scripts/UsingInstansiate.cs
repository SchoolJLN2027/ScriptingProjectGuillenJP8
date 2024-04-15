using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingInstansiate : MonoBehaviour
{
    public Rigidbody rocketPrefab;
    public Transform barrelEnd;
 

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Rigidbody rocketInstansiate;
            rocketInstansiate = Instantiate(rocketPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
            rocketInstansiate.AddForce(barrelEnd.up * 5000);
        }
    }
}
