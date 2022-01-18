using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public float speed = 20.0f;

    void Update()
    {
        //moving fire bullets
        transform.Translate(Vector2.up * Time.deltaTime * speed);
    }
}
