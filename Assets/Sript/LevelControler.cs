using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelControler : MonoBehaviour
{
    public Spawner spawner;

    public static bool finished = false;

    public static int level = 1;

    // Start is called before the first frame update
    void Start()
    {
        finished = false;
    }

    public void Check()
    {
        if (spawner.spawnCounter <= 0)
        {
            Enemy[] enemies = FindObjectsOfType<Enemy>();

            if (enemies.Length <= 0)
            {
                //Victory();
            
            }
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
