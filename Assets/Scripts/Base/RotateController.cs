using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateController : MonoBehaviour
{
    [SerializeField] protected float rotateSpeed;

    public virtual void Rotate(float xAngle, float yAngle, float zAngle)
    {
        transform.Rotate(xAngle * rotateSpeed, yAngle * rotateSpeed, zAngle * rotateSpeed);
    }

    public virtual void RotateRight()
    {
        Rotate(0, 0, -1);
    }

    public virtual void RotateLeft()
    {
        Rotate(0, 0, 1);
    }
    
}
