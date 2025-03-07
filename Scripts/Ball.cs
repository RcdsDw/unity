using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public Vector2 direction;
    public float scaleX;
    public float scaleY;
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
        Vector2 BL = cam.ScreenToWorldPoint(new Vector2(0, 0));
        Vector2 TR = cam.ScreenToWorldPoint(new Vector2(cam.scaledPixelWidth, cam.scaledPixelHeight));
        Vector2 pos = transform.position;

        if (pos.x <= BL.x || pos.x >= TR.x) direction.x *= -1;
        else if (pos.y <= BL.y || pos.y >= TR.y) direction.y *= -1;
        pos.x += direction.x * speed * Time.deltaTime;
        pos.y += direction.y * speed * Time.deltaTime;

        transform.position = pos;
    }

    void changeDirection()
    {
        direction.x *= -1;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Collider2D coll = collision.collider;

        if (coll.tag == "Raquet") changeDirection();
    }
}
