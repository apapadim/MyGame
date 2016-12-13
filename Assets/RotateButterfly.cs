using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateButterfly : MonoBehaviour {
    public float speed;
    
    // Use this for initialization
    void Start () {
        speed = 60f;        
    }
	
	// Update is called once per frame
	void Update () {

        float rotate = Input.GetAxis("Rotate");

        transform.Rotate(0f, speed * rotate * Time.deltaTime, 0f);
    }
}
