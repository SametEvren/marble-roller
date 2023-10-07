using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public float scrollSpeed = 0.5f;
    public Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
    }
    private void Update()
    {
        Vector2 offset = new Vector2(Time.time * scrollSpeed, 0);
        //float offset = Time.time * scrollSpeed;
        rend.material.mainTextureOffset = offset;
        //renderer.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
        //rend.material.SetTextureOffset("_BumpMap", new Vector2(offset, 0));

    }
}
