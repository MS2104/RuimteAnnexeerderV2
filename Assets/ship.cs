using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ship : MonoBehaviour
{
    Vector2 shipPosition;
    [SerializeField] float speed = 1.0f;
    
    public GameObject bulletObj;

    // Start is called before the first frame update
    void Start()
    {
        shipPosition = transform.position;
    }

    void Shoot()
    {
        Vector2 spawnPos = new Vector2(transform.position.x, -7.0f);
        Instantiate(bulletObj, spawnPos, Quaternion.identity);
    }
    
    // Update is called once per frame
    void Update()
    {
        // Left
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime); 
        }

        // Right
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

        // Shoot
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }
}
