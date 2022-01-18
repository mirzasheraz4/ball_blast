using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 20.0f;
    public float xRange = 7.82f;
    public GameObject Bullet;
    public float startDelay = 0.1f;




    void Update()
    {
        InvokeRepeating("FireBullet", startDelay, 0f);
        movement();
    }
    void FireBullet()
    {
        //fire bullets in intervals
        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(Bullet, transform.position, Bullet.transform.rotation);
        }
    }

    void movement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        //left boundry restriction
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector2(-xRange, transform.position.y);
        }
        //right boundry restriction
        if (transform.position.x > xRange)
        {
            transform.position = new Vector2(xRange, transform.position.y);
        }
        //player movement
        transform.Translate(Vector2.right * Time.deltaTime * speed * horizontalInput);
    }
}
