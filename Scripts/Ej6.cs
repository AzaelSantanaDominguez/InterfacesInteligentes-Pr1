using UnityEngine;

public class Ej6 : MonoBehaviour
{   
    public float velocity = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {}
    // Update is called once per frame
    void Update() {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.UpArrow)) Debug.Log("Flecha arriba presionada:" + verticalInput * velocity);
        if (Input.GetKey(KeyCode.DownArrow)) Debug.Log("Flecha abajo presionada:" + verticalInput * velocity);
        if (Input.GetKey(KeyCode.LeftArrow)) Debug.Log("Flecha izquierda presionada:" + horizontalInput * velocity);
        if (Input.GetKey(KeyCode.RightArrow)) Debug.Log("Flecha derecha presionada:" + horizontalInput * velocity);
    }
}
