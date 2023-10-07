using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundsMoving : MonoBehaviour
{
    float timer = 0;
    public bool stableObject;
    void Update()
    {
        if(timer<2)
        {
            timer += Time.deltaTime;

        }
        if (timer > 1 && stableObject == true)
        {
            transform.position += Vector3.left * Time.deltaTime * 9f;
        }
        if(stableObject == false)
        {
            transform.position += Vector3.left * Time.deltaTime * 9f;
        }
    }
}
