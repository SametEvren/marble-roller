using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMovement : MonoBehaviour
{
    public float speed = 10f;
    public float gravForce = 5f;
    public bool gravSwitch = false;
    public Rigidbody rb;
    public int x, y, z;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        ParticleManager.instance.bubbleStream.transform.position = transform.position + Vector3.back;
        ParticleManager.instance.iceSpikeTrail.transform.position = transform.position;
        transform.Rotate(new Vector3(x, y, z));
        //if(rb.velocity.x < 0f)
        //{
        //    rb.velocity = new Vector3(rb.velocity.x * -1, rb.velocity.y, rb.velocity.z);
        //}
        //rb.velocity = speed * rb.velocity.normalized;
        if (Input.GetMouseButtonDown(0))
        {
            gravSwitch = !gravSwitch;
            AndroidHaptic.HapticFeedback();
        }
        if (gravSwitch)
        {
            //rb.AddForce(new Vector3(0, gravForce, 0));
            Physics.gravity = new Vector3(0, gravForce, 0);
            z = 11;
        }
        else
        {
            //rb.AddForce(new Vector3(0, -gravForce, 0));

            Physics.gravity = new Vector3(0, -gravForce, 0);
            z = -11;
        }
    }

}
