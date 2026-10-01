using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public int framesToChangeColor = 120;
    public int frameCounter = 0;

    private Color color;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   
        // We get the initial color of the object to change it later
        color = GetComponent<Renderer>().material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
        frameCounter++;
        // We change the color of the object every framesToChangeColor frames
        if (frameCounter >= framesToChangeColor)
        {
            int randomPosition = Random.Range(0, 3);
            switch (randomPosition)
            {
                case 0:
                    color.r = Random.Range(0f, 1f);
                    break;
                case 1:
                    color.g = Random.Range(0f, 1f);
                    break;
                case 2:
                    color.b = Random.Range(0f, 1f);
                    break;
            }
            GetComponent<Renderer>().material.color = color;
            frameCounter = 0;
        }
    }
}
