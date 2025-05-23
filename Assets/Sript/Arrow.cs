using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public Vector2 direction;
    private Rigidbody2D rigibody;
    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        rigibody = GetComponent<Rigidbody2D>();

        Destroy(gameObject, 4f);
    }

    // Update is called once per frame
    public void Shoot()
    {

        rigibody.velocity = direction * speed;


    }
    void Update()
    {
        
    }
}
