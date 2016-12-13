using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveButterfly : MonoBehaviour {
    public float speed;
    public float currentZ;
    // Use this for initialization
    void Start () {
        speed = 7f; 
        currentZ= Input.GetAxis("Z");
    }
	
	// Update is called once per frame
	void Update () {

        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        float moveZ = Input.GetAxis("Z");
        currentZ += moveZ;

        if (currentZ < 0.000f)
        {
            moveZ = 0f;
            currentZ = 0f;
        }
            

        transform.Translate(0f, speed * moveZ * Time.deltaTime, speed * moveX * Time.deltaTime);
                  
        
    }


    
}
