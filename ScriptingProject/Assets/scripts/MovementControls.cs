using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControls : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    // Start is called before the first frame update
    void Movement()
    {
        float forward = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float turn = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        transform.Translate(Vector3.forward * forward);
        transform.Rotate(Vector3.up * turn);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
}
