using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CrossBowShoot : MonoBehaviour
{
    public Arrow arrowPrefab;
    public float shootInterval = 0.75f;
    private float shootTimer = 0;
    // Start is called before the first frame update
    void Start()
    {
      
    }

   
    
    // Update is called once per frame
    void Update()
    {
        shootTimer -= Time.deltaTime;
       if (Input.GetMouseButton(0))
        {
          if (shootTimer <= 0)
            {
                Instantiate(arrowPrefab, transform.position, transform.rotation);
                shootTimer = shootInterval;
            }
           
           
        }
    }
}
