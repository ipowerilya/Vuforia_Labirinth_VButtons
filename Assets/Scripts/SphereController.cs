using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    public GameObject plane;
    public GameObject Spawn;
    public Rigidbody rb;


    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < plane.transform.position.y - 2)
        {
            transform.position = Spawn.transform.position;
            rb.velocity = new Vector3(0f, 0f, 0f);

        }
    }
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
}
