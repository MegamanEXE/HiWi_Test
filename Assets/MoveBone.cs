using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBone : MonoBehaviour
{
    private bool direction;
     // Use this for initialization
     void Start()
     {
         direction = true;
         StartCoroutine(RotateObject(60, Vector3.right, 1));
     }
 
     IEnumerator RotateObject(float angle, Vector3 axis, float inTime)
     {
         // calculate rotation speed         
         float rotationSpeed = angle / inTime;
         
         while (true)
         {
             // save starting rotation position
             Quaternion startRotation = transform.rotation;
             
             float deltaAngle = 0;
 
             // rotate until reaching angle
             while (deltaAngle < angle)
             {
                     deltaAngle += rotationSpeed * Time.deltaTime;
                     deltaAngle = Mathf.Min(deltaAngle, angle);
                if (direction)
                     transform.rotation = startRotation * Quaternion.AngleAxis(deltaAngle, axis);
                else 
                    transform.rotation = startRotation * Quaternion.AngleAxis(-1*deltaAngle, axis);
                    
                 yield return null;
             }
             direction = !direction;  
         }
     }
 }

