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
        Destroy(GameObject.FindGameObjectWithTag("Shape"));
        Instantiate(cubePrefab, centerPos.transform.position, cubePrefab.transform.rotation);
    }

    public void CreateSphere()
    {
        Destroy(GameObject.FindGameObjectWithTag("Shape"));
        Instantiate(spherePrefab, centerPos.transform.position, spherePrefab.transform.rotation);
    }

    public void CreateCylinder()
    {
        Destroy(GameObject.FindGameObjectWithTag("Shape"));
        Instantiate(cylinderPrefab, centerPos.transform.position, cylinderPrefab.transform.rotation);
    }
}
