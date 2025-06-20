using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Tooltip("The enemy prefab ti spawn")] public Enemy enemyPrefab;

    [Header("position to spawn")]
    public Transform topBorder;
    public Transform bottomBorder;

    [Header("position time to spawn")]
    public float spawnIntervalMax = 3.5f;
    public float spawnIntervalMin = 1f;

    public float spawnTimer = 0f;
    public int spawnCounter = 10;
    private int spawnAddPerLevel = 5;

    
    
    
    // Start is called before the first frame update
    void Start()
    {
        spawnCounter += spawnAddPerLevel * LevelControler.level;
    }

    // Update is called once per frame
    void Update()
    {
        if(LevelControler.finished == false)
        {
            if (spawnTimer > 0)
            {
                spawnTimer -= Time.deltaTime;

            }
            else if (spawnCounter > 0)
            {
                Spawn();

            }

        }
    }

    public void Spawn()
    {
        spawnCounter--;

        spawnTimer = Random.Range(spawnIntervalMin, spawnIntervalMax);

        Vector2 randomPosition = new Vector2(this.transform.position.x, Random.Range(topBorder.position.y, bottomBorder.position.y));

        Instantiate(enemyPrefab, randomPosition, Quaternion.identity);

    }


}
