using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce = 10;
    public float gravityModifier=2;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            playerRb.AddForce(Vector2.up * jumpForce, ForceMode.Impulse);
        }
        if (collision.gameObject.CompareTag("bullet"))
        {
            playerRb.transform.localScale = transform.localScale - new Vector3(Time.deltaTime * 1, Time.deltaTime * 1, 0); ;
            if(playerRb.transform.localScale.x == 0 && playerRb.transform.localScale.y == 0) { }
            {
                Destroy(gameObject);
            }
        }
    }
}
