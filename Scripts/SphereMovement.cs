using UnityEngine;

public class SphereMovement : MonoBehaviour
{   
    public float speed = 5f; // Speed of the sphere movement
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        float horizontal = 0;
        float vertical = 0;

        if (Input.GetKey(KeyCode.W)) vertical = 1;
        if (Input.GetKey(KeyCode.S)) vertical = -1;
        if (Input.GetKey(KeyCode.A)) horizontal = -1;
        if (Input.GetKey(KeyCode.D)) horizontal = 1;

        transform.Translate(horizontal * speed * Time.deltaTime, vertical * speed * Time.deltaTime, 0);
        
    }
}
