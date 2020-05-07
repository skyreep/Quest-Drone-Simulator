using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponFire : MonoBehaviour
{
    public float thrust = 1.0f;
    public Rigidbody rb;
    public GameObject dronePrefab;
    //public GameObject projectile;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        Physics.IgnoreCollision(dronePrefab.GetComponent<Collider>(), GetComponent<Collider>());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            //Instantiate(projectile);
            //projectile.transform.SetParent(dronePrefab.transform);
            rb.useGravity = true;
            rb.AddRelativeForce(0, thrust, 0, ForceMode.Impulse);
        }
    }


}
