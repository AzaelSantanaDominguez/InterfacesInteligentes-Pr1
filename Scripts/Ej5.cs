using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Vector3 displacement;
    private Vector3 initialPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Jump") > 0)
        {
            transform.position = initialPosition + displacement;
        }
    }
}
