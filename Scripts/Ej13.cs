using UnityEngine;

public class Ej13 : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 100f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(0, horizontalInput * rotationSpeed * Time.deltaTime, 0);
        transform.Translate(transform.forward * speed * Time.deltaTime);
    }
}
