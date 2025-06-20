using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float bordertPosX;

    public float shootInterval = 1f;
    public float shootTimer = 0f;

    public float speedPerLevel = 0.2f;
    public int health;
    public Transform destination;
    public float speed = 1f;
    public void TakeDamage()
    {
        health -= 1;

        if (health <= 0)
            Destroy(gameObject);
    }

    private void Start()
    {
        bordertPosX = Corn.singLeton.transform.position.x;
    }


    private void Update()
    {
        if (shootTimer > 0)
        {
            shootTimer -= Time.deltaTime;

        }
        Vector2 direction = new Vector2(-1, 0);
        transform.position += (Vector3) direction.normalized * Time.deltaTime * speed;

        float enemyPosX = transform.position.x;
        if(enemyPosX < bordertPosX)
        {
            Attack();
        }
    }

    public void TakeDamage2()
    {
        health -= 1;

        if (health <= 0)
        {
            Die();
        }
    }

    public void Attack()
    {
        Corn.singLeton.TakeDamage();
    }

    public void Die()
    {

        Destroy(gameObject);

    }

      


}
