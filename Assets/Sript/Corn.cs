using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corn : MonoBehaviour
{
    public static Corn singLeton;
    public int health;
    public int crystals;

    public int initHealth;
    public int healthPerUpgrade;

    private void Awake()
    {
        singLeton = this;
        int healthBonus = healthPerUpgrade * PlayerPrefs.GetInt("healthGrade", 0);
        health = initHealth + healthBonus;
        crystals = PlayerPrefs.GetInt("crystals", 0);
    }

    public void TakeDamage() 
    {
        if(health > 0)
        {
            health -= 1;
        }


    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
