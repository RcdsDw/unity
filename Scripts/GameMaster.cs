using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public Ball ball;
    public Raquet[] raquets;

    private Vector2 bPos;
    private float bsX;
    private float bsY;
    private float bLeft;
    private float bRight;
    private float bTop;
    private float bBottom;

    void Start()
    {
        bsX = ball.scaleX;
        bsY = ball.scaleY;
    }

    void Update()
    {
        bPos = ball.transform.position;
        bLeft = bPos.x - bsX / 2;
        bRight = bPos.x + bsX / 2;
        bTop = bPos.y + bsY / 2;
        bBottom = bPos.y - bsY / 2;
        Vector2 bDirection = ball.direction;
        float bSpeed = ball.speed;

        foreach (Raquet raquet in raquets)
        {
            Vector2 rPos = raquet.transform.position;
            float rsX = raquet.scaleX;
            float rsY = raquet.scaleY;
            float rLeft = rPos.x - rsX / 2;
            float rRight = rPos.x + rsX / 2;
            float rTop = rPos.y + rsY / 2;
            float rBottom = rPos.y - rsY / 2;

            bool blrr = bLeft < rRight;
            bool brrl = bRight > rLeft;
            bool btrb = bTop > rBottom;
            bool bbrt = bBottom < rTop;

            //Debug.Log(raquet.isCol);

            if (blrr && brrl && btrb && bbrt)
            {
                if (raquet.isCol == false)
                {
                    Debug.Log("In if");
                    bDirection.x *= -1;
                    raquet.isCol = true;
            }
        }
            else
            {
                raquet.isCol = false;
            }
        }
        ball.direction = bDirection;
        bPos.x += bDirection.x * bSpeed * Time.deltaTime;
        ball.transform.position = bPos;
    }
}
