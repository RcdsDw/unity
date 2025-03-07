using UnityEngine;

public class PingPong : MonoBehaviour
{
    public Vector2 min;
    public Vector2 max;
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 destination = new Vector2();
        Vector2 pos = transform.position;
        Vector2 DMax = max - pos;
        Vector2 DMin = min - pos;

        if (DMin.magnitude <= 0.1) 
        {
            destination = max;
        }
        else if (DMax.magnitude <= 0.1)
        {
            destination = min;
        }
        transform.position = Vector2.Lerp(pos, destination, speed);

        //float dx = pos.x;

        //if (dx >= max.x) speed = -0.05f;
        //else if (dx <= min.x) speed = 0.05f;

        //dx += speed;

        //pos.x = dx;

        //transform.position = pos; // With transform
    }
}
