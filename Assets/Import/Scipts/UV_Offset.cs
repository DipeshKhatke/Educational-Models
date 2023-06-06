using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UV_Offset : MonoBehaviour
{
    // Scroll the main texture based on time

    public float x_scrollSpeed = 0.5f;
    public float y_scrollSpeed = 0.5f;
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        float x_offset = Time.time * x_scrollSpeed;
        float y_offset = Time.time * y_scrollSpeed;
        rend.material.mainTextureOffset = new Vector2(x_offset, y_offset);
    }
}