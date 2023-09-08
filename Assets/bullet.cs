using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class bullet : MonoBehaviour
{
    Vector2 bulletPosition;
    float bulletVelocity = 10f;
    float maxHeight = 15.0f;

    // int damage = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision is with the object you want to destroy
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject); // Destroy the object
            Destroy(gameObject); // Destroy the bullet (optional)
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * bulletVelocity * Time.deltaTime);

        if (transform.position.y > maxHeight) 
        { 
            Destroy(gameObject);
        }
    }
}
