using UnityEngine;

public class CubeMovement3 : MonoBehaviour
{
    public float speed = 5f;
    private GameObject goal;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        goal = GameObject.FindGameObjectWithTag("Meta");
    }

    // Update is called once per frame
    void Update()
    {
       Vector3 direction = (goal.transform.position - transform.position).normalized;
       transform.LookAt(goal.transform.position);
       transform.Translate(direction * speed * Time.deltaTime, Space.World);
    }
}
