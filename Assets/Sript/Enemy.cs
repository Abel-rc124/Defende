using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public Transform destination;
    public float speed = 1f;
    public void TakeDamage()
    {
        health -= 1;

        if (health <= 0)
            Destroy(gameObject);
    }


    private void Update()
    {
        Vector2 direction = destination.position - transform.position;
        transform.position += (Vector3) direction.normalized * Time.deltaTime * speed;
    }
}
