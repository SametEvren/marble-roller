using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableCollidingObstacles : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {        
        if(other.CompareTag("Obstacle"))
        {
            gameObject.SetActive(false);
        }
    }
}
