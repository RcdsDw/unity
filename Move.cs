using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Debug.Log("Coubeh");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        float dx = pos.x;
        float dy = pos.y;

        dx += speed * Input.GetAxis("Horizontal");
        dy += speed * Input.GetAxis("Vertical");

        pos.x = dx; pos.y = dy;

        transform.position = pos;

        //Debug.Log("Update Coubeh");
        //if (Input.GetButton("Left")) pos.x = pos.x - speed * Time.deltaTime;

        //if (Input.GetButton("Right")) pos.x = pos.x + speed * Time.deltaTime;

        //if (Input.GetButton("Up")) pos.y = pos.y + speed * Time.deltaTime;

        //if (Input.GetButton("Down")) pos.y = pos.y - speed * Time.deltaTime;

    }

    void FixedUpdate()
    {
        //Debug.Log("Fixed Update Apagnan");
    }
}
