using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject centerPos;
    public GameObject cubePrefab;
    public GameObject spherePrefab;
    public GameObject cylinderPrefab;

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
        ActionManager.shape = target.GetComponent<ShapeAction>();
    }
}
