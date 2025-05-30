using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballesta : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 aimDirection;
    public float shootInterval = 0.75f;
    private float shootTimer = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (shootTimer > 0)
        {
            shootTimer -= Time.deltaTime;
        }

        if (Input.GetMouseButton(0))
        {
            Vector2 mouseScreenPos = Input.mousePosition;

            Vector2 mouseScenePos = Camera.main.ScreenToWorldPoint(mouseScreenPos);

            Vector2 crossbowPos = transform.position;

            Vector2 wantedDirection = mouseScenePos - crossbowPos;

            Vector2 defaultDirection = Vector2.up;

            float angle = Vector2.SignedAngle(defaultDirection, wantedDirection);

            Vector3 newEuler = new Vector3(0, 0, angle);

            transform.localEulerAngles = newEuler;

            aimDirection = defaultDirection;
        }



    }

    public Vector2 GetDirection() 
    {
        return aimDirection;
    }
     
      
     
}
