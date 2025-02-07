using UnityEngine;

public class Raquet : MonoBehaviour
{
    public float speed;
    public KeyCode up;
    public KeyCode down;
    public float scaleX;
    public float scaleY;
    public bool isCol = false;
    private Camera cam;

    void Start()
    {
        cam = Camera.main; 
        scaleX = transform.localScale.x;
        scaleY = transform.localScale.y;
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        float direction = speed * Time.deltaTime;
        Vector2 BL = cam.ScreenToWorldPoint(new Vector2(0, 0));
        Vector2 TR = cam.ScreenToWorldPoint(new Vector2(cam.scaledPixelWidth, cam.scaledPixelHeight));
        Vector2 pos = transform.position;

        if (Input.GetKey(up) && pos.y <= TR.y - 10f) pos.y += direction;
        else if (Input.GetKey(down) && pos.y >= BL.y + 10f) pos.y -= direction;

        transform.position = pos;
    }
}
