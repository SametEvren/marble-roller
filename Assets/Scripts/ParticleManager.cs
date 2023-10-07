using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    #region Singleton

    public static ParticleManager instance;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
    }
    #endregion
    public ParticleSystem bubbleStream;
    public ParticleSystem iceSpikeTrail;
    public ParticleSystem goldParticle;
}
