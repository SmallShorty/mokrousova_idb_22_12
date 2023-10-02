using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Renderer r;
    public float timer = 0.0f;

    void FixedUpdate()
    {
        timer += Time.deltaTime;
        if (timer >= 4.0f)
        {
            r.material.color = new Color(Random.value, Random.value, Random.value, 1.0f);
            timer = 0;
        }
    }
}