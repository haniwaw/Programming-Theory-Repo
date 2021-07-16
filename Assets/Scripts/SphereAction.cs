using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereAction : ShapeAction
{
    public override void Action()
    {
        transform.RotateAround(transform.position, Vector3.right, actionPower);
    }
}
