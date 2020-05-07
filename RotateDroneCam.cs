using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateDroneCam : MonoBehaviour
{
    public float speed = 5.0f;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Spin the object around the world origin at 20 degrees/second.
        transform.RotateAround(target.transform.position, Vector3.up, speed * Time.deltaTime);
        //transform.Rotate(Vector3.up, 1 * speed * Time.deltaTime);
    }
}
