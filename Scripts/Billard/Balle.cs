using UnityEngine;

public class Balle : MonoBehaviour
{
    private Vector2 mousePosDrag;
    private Vector2 mousePosDepart;
    private Rigidbody2D ball_Rigidbody;
    private Vector2 direction;
    public float force = 10f;
    private Vector2 forceDirection;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ball_Rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnMouseDown()
    {
        mousePosDepart = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseDrag()
    {
        mousePosDrag = (Vector2) Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseUp()
    {
        direction = mousePosDepart - mousePosDrag;
        forceDirection = new Vector2(direction.x, direction.y);

        ball_Rigidbody.AddForceAtPosition(forceDirection * force, mousePosDepart, ForceMode2D.Impulse);
    }
}