using UnityEngine;

public class ShowTransform : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Position: " + GetComponent<Transform>().position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
