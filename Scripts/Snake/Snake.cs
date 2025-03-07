using UnityEngine;

public class Snake : MonoBehaviour
{
    public int speed;
    public KeyCode up;
    public KeyCode down;
    public KeyCode right;
    public KeyCode left;

    private string lastInput;
    private int childCount;

    public GameObject part;

    private Camera cam;

    private Vector2 pos;
    [SerializeField]
    private Vector3 direction;
    private Vector2 CornerBottomLeft;
    private Vector2 CornerTopRight;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = Camera.main;
        CornerBottomLeft = cam.ScreenToWorldPoint(new Vector2(0, 0));
        CornerTopRight = cam.ScreenToWorldPoint(new Vector2(cam.scaledPixelWidth, cam.scaledPixelHeight));
        //childCount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        //Teleportation();
    }

    void changeDirectionY()
    {
        direction.y *= -1;
    }

    void changeDirectionX()
    {
        direction.x *= -1;
    }

    private void Teleportation()
    {   
        if (pos.x > CornerTopRight.x) pos.x = CornerBottomLeft.x;
        else if (pos.x < CornerBottomLeft.x) pos.x = CornerTopRight.x;

        if (pos.y > CornerTopRight.y) pos.y = CornerBottomLeft.y;
        else if (pos.y < CornerBottomLeft.y) pos.y = CornerTopRight.y;
        transform.position = pos;
    }

    private void Move()
    {
        //if (Input.GetKeyDown(up) && lastInput != "down")
        //{
        //    changeDirectionY();
        //    lastInput = "up";
        //}
        //else if (Input.GetKeyDown(down) && lastInput != "up")
        //{
        //    changeDirectionY();
        //    lastInput = "down";
        //}
        //else if (Input.GetKeyDown(right) && lastInput != "left")
        //{
        //    changeDirectionX();
        //    lastInput = "right";
        //}
        //else if (Input.GetKeyDown(left) && lastInput != "right")
        //{
        //    changeDirectionX();
        //    lastInput = "left";
        //}

        Debug.Log(direction);
        transform.position = transform.position + direction;
    }

    private void AddNewPart()
    {
        Vector3 childPos = pos;
        switch (lastInput)
        {
            case "up":
                childPos.y = pos.y - 3 * childCount;
                break;
            case "down":
                childPos.y = pos.y + 3 * childCount;
                break;
            case "right":
                childPos.x = pos.x - 3 * childCount;
                break;
            case "left":
                childPos.x = pos.x + 3 * childCount;
                break;
        }

        GameObject child = GameObject.Instantiate(part, childPos, part.transform.rotation);
        child.transform.parent = this.transform;

        childCount++;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Apple")
        {
            Debug.Log("Oui");
            GameObject.Destroy(collider.gameObject);
            //AddNewPart();
        }
    }
}
