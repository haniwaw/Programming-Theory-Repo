using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ShapeAction : MonoBehaviour
{
    private Rigidbody shapeRb;
    public float jumpSpeed = 2f;
    

    private void Start()
    {
        shapeRb = GetComponent<Rigidbody>();
    }

    public void Jump()
    {
        shapeRb.AddForce(Vector3.up * jumpSpeed);
    }

    public abstract void Action();
}
