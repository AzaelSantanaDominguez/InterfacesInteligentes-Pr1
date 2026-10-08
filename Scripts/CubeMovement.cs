using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){}

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = 0;
        float verticalInput = 0;

        if (Input.GetKey(KeyCode.UpArrow)) verticalInput = 1;
        if (Input.GetKey(KeyCode.DownArrow)) verticalInput = -1;
        if (Input.GetKey(KeyCode.LeftArrow)) horizontalInput = -1;
        if (Input.GetKey(KeyCode.RightArrow)) horizontalInput = 1;

        transform.Translate(horizontalInput * speed * Time.deltaTime, verticalInput * speed * Time.deltaTime, 0f);
    }
}
