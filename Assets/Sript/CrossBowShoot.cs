using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CrossBowShoot : MonoBehaviour
{
    public Arrow arrowPrefab;
    // Start is called before the first frame update
    void Start()
    {
      
    }

   
    
    // Update is called once per frame
    void Update()
    {
       if (Input.GetMouseButtonDown(0))
        {

            Arrow new_arrow = Instantiate (arrowPrefab);
            new_arrow.transform.position = transform.position;
            new_arrow.transform.rotation = transform.rotation;

            new_arrow.direction = transform.forward;
            new_arrow.Shoot();
        }
    }
}
