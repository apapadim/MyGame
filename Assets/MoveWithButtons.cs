using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveWithButtons : MonoBehaviour{
    
    private float speed, speedRotate;
    bool flagForward, flagUp, flagDown, flagRotateRight, flagRotateLeft;
    float currentz;
    
    void Start()
    {
        speed = 7f;
        speedRotate = 60f;
        flagForward = false;
        flagUp = false;
        flagDown = false;
        flagRotateRight = false;
        flagRotateLeft = false;
        currentz = 0.000f;
    }
    public void Update()
    {
        if (flagForward) pressForward();

        if (flagUp) pressUp();

        if (flagDown) pressDown();

        if (flagRotateLeft) rotateLeft();

        if (flagRotateRight) rotateRight();
    }


    public void pressForward()
    {                
        transform.Translate(0f, 0f, -speed * Time.deltaTime);
        flagForward = true;
    }

    public void releaseForward()
    {             
        transform.Translate(0f, 0f, 0f);
        flagForward = false;
    }

    public void pressUp()
    {
        currentz += speed * Time.deltaTime;
        transform.Translate(0f, speed * Time.deltaTime, 0f);
        flagUp = true;
        
    }

    public void releaseUp()
    {
        transform.Translate(0f, 0f, 0f);
        flagUp = false;
    }

    public void pressDown()
    {
        currentz -= speed * Time.deltaTime;

        if (currentz < 0.000f)
        {
            speed = 0f;
            currentz = 0f;
        }
                
        transform.Translate(0f, -speed * Time.deltaTime, 0f);
        speed = 7f;
        flagDown = true;
        
    }

    public void releaseDown()
    {
        transform.Translate(0f, 0f, 0f);
        flagDown = false;
    }

    public void rotateLeft()
    {
        transform.Rotate(0f, -speedRotate * Time.deltaTime, 0f);
        flagRotateLeft = true;        
    }

    public void releaseLeft()
    {
        transform.Rotate(0f, 0f, 0f);
        flagRotateLeft = false;
    }

    public void rotateRight()
    {
        transform.Rotate(0f, speedRotate * Time.deltaTime, 0f);
        flagRotateRight = true;
    }

    public void releaseRight()
    {
        transform.Rotate(0f, 0f, 0f);
        flagRotateRight = false;
    }

}

