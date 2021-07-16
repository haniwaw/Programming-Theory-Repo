using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAction : ShapeAction
{
    public override void Action()
    {
        transform.RotateAround(transform.position, Vector3.right, 30 * Time.deltaTime);
    }
}
