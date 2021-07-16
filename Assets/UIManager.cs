using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static ShapeAction shape;

    public GameObject centerPos;
    public GameObject cubePrefab;
    public GameObject spherePrefab;
    public GameObject cylinderPrefab;

    public void JumpShape()
    {
        if (shape != null)
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

    public void CreateCube()
    {
        CreateShape(cubePrefab);
    }

    public void CreateSphere()
    {
        CreateShape(spherePrefab);
    }

    public void CreateCylinder()
    {
        CreateShape(cylinderPrefab);
    }

    void CreateShape(GameObject Obj)
    {
        Destroy(GameObject.FindGameObjectWithTag("Shape"));
        GameObject target = Instantiate(Obj, centerPos.transform.position, Obj.transform.rotation);
        shape = target.GetComponent<ShapeAction>();
    }
}
