using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotationSpeed;
    //Vector3 currentEulerAngles;
    public Ball ball;

    //public KeyCode xRot;
    //public KeyCode yRot;
    //public KeyCode zRot;

    //public float x;
    //public float y;
    //public float z;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(xRot)) x = 1 - x;
        //if (Input.GetKeyDown(yRot)) y = 1 - y;
        //if (Input.GetKeyDown(zRot)) z = 1 - z;

        //currentEulerAngles += new Vector3(x, y, z) * Time.deltaTime * rotationSpeed;
        //currentRotation.eulerAngles = currentEulerAngles;

        
        //transform.position = Vector3.Lerp(transform.position, ball.transform.position, rotationSpeed * Time.deltaTime);
        Vector2 vision = new Vector2(0, transform.localScale.x / 2);

        Vector2 direction = ball.transform.position - transform.position;

        transform.rotation = Quaternion.FromToRotation(vision, direction); ;
    }
}
