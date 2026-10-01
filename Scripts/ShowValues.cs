using UnityEngine;

public class ShowValues : MonoBehaviour
{
    public Vector3 values1;
    public Vector3 values2;

    public float values1Magnitude;
    public float values2Magnitude;
    public float angleBetweenValues;
    public float distanceBetweenValues;
    public string higherValue;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CalculateValues();
        PrintValues();
    }

    void PrintValues()
    {
        Debug.Log("Values 1: " + values1);
        Debug.Log("Values 2: " + values2);
        Debug.Log("Magnitude of Values 1: " + values1Magnitude);
        Debug.Log("Magnitude of Values 2: " + values2Magnitude);
        Debug.Log("Angle between Values: " + angleBetweenValues);
        Debug.Log("Distance between Values: " + distanceBetweenValues);
        Debug.Log(higherValue);
    }

    void CalculateValues()
    {
        values1Magnitude = values1.magnitude;
        values2Magnitude = values2.magnitude;
        angleBetweenValues = Vector3.Angle(values1, values2);
        distanceBetweenValues = Vector3.Distance(values1, values2);
        higherValue = values1Magnitude > values2Magnitude ? "values1 is higher" : "values2 is higher";
    }
    
    // This method is called when the script is loaded or a value is changed in the inspector (Editor only)
    void OnValidate()
    {
        CalculateValues();
        PrintValues();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
