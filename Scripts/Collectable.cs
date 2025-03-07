using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Collectable : MonoBehaviour
{
    public float speed;
    private bool isTrigger = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        Vector2 pos = transform.position;
        if (collider.tag == "Ball")
        {
            if (isTrigger)
            {
                transform.position = Vector2.Lerp(pos, collider.transform.position, speed);
                SpriteRenderer sr = GetComponent<SpriteRenderer>();
                if (sr != null)
                {
                    sr.color = Color.red;
                }
                pos = transform.position;

            } else
            {
                isTrigger = true;
            }
        };
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision != null)
        {
            SpriteRenderer sr = GetComponent<SpriteRenderer>();
            if (sr != null)
            {
                sr.color = Color.yellow;
            }
        }
    }
}
