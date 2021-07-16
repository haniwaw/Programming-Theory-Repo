using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ShapeAction : MonoBehaviour
{
    protected Rigidbody shapeRb;
    protected float m_JumpSpeed = 200f; // add new private backing field
    public float JumpSpeed
    {
        get { return m_JumpSpeed; } // getter returns backing field
        set
        {
            if (value < 0.0f)
            {
                Debug.LogError("You can't set a negative speed!");
            }
            else
            {
                m_JumpSpeed = value; // original setter now in if/else statement
            }
        } // setter uses backing field
    }
    protected float m_actionPower = 1f;
    public float actionPower
    {
        get { return m_actionPower; } // getter returns backing field
        set
        {
            if (value < 0.0f)
            {
                Debug.LogError("You can't set a negative power!");
            }
            else
            {
                m_actionPower = value; // original setter now in if/else statement
            }
        } // setter uses backing field
    }


    private void Start()
    {
        shapeRb = GetComponent<Rigidbody>();
    }

    public void Jump()
    {
        shapeRb.AddForce(Vector3.up * m_JumpSpeed);
    }

    public abstract void Action();
}
