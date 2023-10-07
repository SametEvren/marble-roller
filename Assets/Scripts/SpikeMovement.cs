using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeMovement : MonoBehaviour
{
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * 17f;
        transform.position += Vector3.down * Time.deltaTime * 5f;
        transform.Rotate(new Vector3(5.5f, 0, 0));
    }
}
