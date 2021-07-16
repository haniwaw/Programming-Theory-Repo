using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionManager : MonoBehaviour
{
    public static ShapeAction shape;

    public void JumpShape()
    {
        if(shape != null)
        {
            shape.Jump();
            Debug.Log("Jump!");
        }
    }

    public void ActionShape()
    {
        if (shape != null)
        {
            shape.Action();
            Debug.Log("Action!!");
        }
    }
}
