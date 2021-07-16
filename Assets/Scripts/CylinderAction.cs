using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderAction : ShapeAction
{
    public override void Action()
    {
        transform.RotateAround(transform.position, Vector3.forward, actionPower);
    }
}
