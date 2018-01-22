using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockers : MonoBehaviour
{
    //I want to know about all the cylinders.
    public GameObject b1;
    public GameObject b2;
    public GameObject b3;
    public GameObject b4;
    public GameObject b5;
    public GameObject b6;

    //and i want to know all of the cylinders positions    
    private Vector3 b1pos;
    private Vector3 b2pos;
    private Vector3 b3pos;
    private Vector3 b4pos;
    private Vector3 b5pos;
    private Vector3 b6pos;
    
    //i want to be able to move them a predetermained didtance..
    private Vector3 activePosition;
    public float raiseHeight = 0;

    //and i want to be able to touch them
    public LayerMask touchMask;

    //i will need to know where to shoot my ray.
    public Camera myCamera;

    void Start()
    {
        //i want to move the cylinders by this much
        activePosition = new Vector3(0, raiseHeight, 0);
        //from these positions, which i will save for later use.
        b1pos = b1.transform.position;
        b2pos = b2.transform.position;
        b3pos = b3.transform.position;
        b4pos = b4.transform.position;
        b5pos = b5.transform.position;
        b6pos = b6.transform.position;
    }

    private void Update()
    {
        //Check for axis input...
        checkAxisInput();
        //check for touch input
        checkForTouch();
        //^^ my best named functions right there ;)
    }

    private void keyboard(GameObject a, Vector3 pos)
    {
        //i made this into the very strangely named function. it should be called like "setPosition"
        //it sets the position of the cylinder when input is detected.
        a.transform.position = pos;
    }

    void checkAxisInput()
    {
        //^^ so well named :D
        //the following code check an axis that i made in the unity editor and if it is greater than .5, calls the set position function that i have named "Keyboard"....
        //i give the "keyboard" (setPosition) function parameters based on the input, raise the cylinders if the axis key binding is pressed, else lowerer it.
        if (Input.GetAxis("Lane1") > 0.5f)
        {
            keyboard(b1, b1pos + activePosition);
        }
        else if (Input.GetAxis("Lane1") < 0.5f)
        {
            keyboard(b1, b1pos);
        }
        if (Input.GetAxis("Lane2") > 0.5f)
        {
            keyboard(b2, b2pos + activePosition);
        }
        else if (Input.GetAxis("Lane2") < 0.5f)
        {
            keyboard(b2, b2pos);
        }
        if (Input.GetAxis("Lane3") > 0.5f)
        {
            keyboard(b3, b3pos + activePosition);
        }
        else if (Input.GetAxis("Lane3") < 0.5f)
        {
            keyboard(b3, b3pos);
        }
        if (Input.GetAxis("Lane4") > 0.5f)
        {
            keyboard(b4, b4pos + activePosition);
        }
        else if (Input.GetAxis("Lane4") < 0.5f)
        {
            keyboard(b4, b4pos);
        }
        if (Input.GetAxis("Lane5") > 0.5f)
        {
            keyboard(b5, b5pos + activePosition);
        }
        else if (Input.GetAxis("Lane5") < 0.5f)
        {
            keyboard(b5, b5pos);
        }
        if (Input.GetAxis("Lane6") > 0.5f)
        {
            keyboard(b6, b6pos + activePosition);
        }
        else if (Input.GetAxis("Lane6") < 0.5f)
        {
            keyboard(b6, b6pos);
        }
    }
    void checkForTouch()
    {
        //the following code checks for touch imput
        //for each touch input, it will raycast, whatever object on the UI layermask gets hit, it will check the hit object's tag
        //if the tag matches the cylinders, it will raise it up, 
        //this remains true if you move your finger or hold it still and will break if you move your finger off of the target
        if(Input.touchCount > 0)
        {
            foreach (Touch touch in Input.touches)
            {
                Ray ray = myCamera.ScreenPointToRay(touch.position);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, touchMask))
                {
                    GameObject object_hit_by_ray = hit.transform.gameObject;

                    if (touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved)
                    {
                        //because the axis for keyboard input is still getting checked, and always returning less than .5,
                        //i don't need to worry about returning the cylinders to their original positions after the touch has been taken care of. 
                        if (object_hit_by_ray.CompareTag ("B1"))
                            b1.transform.position = b1pos + activePosition;
                        if (object_hit_by_ray.CompareTag("B2"))
                            b2.transform.position = b2pos + activePosition;
                        if (object_hit_by_ray.CompareTag("B3"))
                            b3.transform.position = b3pos + activePosition;
                        if (object_hit_by_ray.CompareTag("B4"))
                            b4.transform.position = b4pos + activePosition;
                        if (object_hit_by_ray.CompareTag("B5"))
                            b5.transform.position = b5pos + activePosition;
                        if (object_hit_by_ray.CompareTag("B6"))
                            b6.transform.position = b6pos + activePosition;
                    }
                }
            }
        }
    }
}