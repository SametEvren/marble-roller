using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Vector3 offset;
    public GameObject ball;

    private void Update()
    {        
        transform.position = new Vector3(ball.transform.position.x + offset.x, transform.position.y, ball.transform.position.z + offset.z);
        transform.rotation = Quaternion.identity;
    }
}
