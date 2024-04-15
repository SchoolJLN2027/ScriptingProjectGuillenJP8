using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleCharacter : MonoBehaviour
{
    public class Stuff
    {
        public int bullets = 100;
        public int grenades;
        public int rockets;

        public Stuff(int bul, int gre, int roc)
        {
            bullets = bul;
            grenades = gre;
            rockets = roc;
        }
    }

    public Stuff myStuff = new Stuff(10, 7, 25);
    public float speed;
    public float turnSpeed;
    public Transform firePosition;
    public float bulletSpeed;
    public Rigidbody bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        Movment();
        Shoot();
    }

    void Movment()
    {
        float forward = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float turn = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        transform.Translate(Vector3.forward * forward);
        transform.Rotate(Vector3.up * turn);
    }

    void Shoot()
    {
        if (Input.GetButtonDown("Fire1") && myStuff.bullets > 0)
        {
            Rigidbody bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
            bulletInstance.AddForce(firePosition.forward * bulletSpeed);
            myStuff.bullets--;
        }
    }
}
