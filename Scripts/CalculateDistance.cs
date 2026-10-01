using UnityEngine;

public class CalculateDistance : MonoBehaviour
{
    private GameObject cube;
    private GameObject cylinder;

    private Vector3 cubePosition;
    private Vector3 cylinderPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cube = GameObject.FindWithTag("cubepepe");
        cylinder = GameObject.FindWithTag("cylinderpepe");

        cubePosition = cube.transform.position;
        cylinderPosition = cylinder.transform.position;

        float distance = Vector3.Distance(cubePosition, cylinderPosition);
        Debug.Log("Distance between Cube and Cylinder: " + distance);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentCubePosition = cube.transform.position;
        Vector3 currentCylinderPosition = cylinder.transform.position;

        if (currentCubePosition != cubePosition || currentCylinderPosition != cylinderPosition)
        {
            float distance = Vector3.Distance(currentCubePosition, currentCylinderPosition);
            Debug.Log("Distance between Cube and Cylinder: " + distance);

            cubePosition = currentCubePosition;
            cylinderPosition = currentCylinderPosition;
        }
    }
}
