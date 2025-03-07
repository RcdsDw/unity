using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float speed;
    public KeyCode left;
    public KeyCode right;

    private float direction;

    private Animator animator;
    private SpriteRenderer sr;

    [SerializeField]
    private Vector2 pos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        direction = speed * Time.deltaTime;

        if (Input.GetKey(left) || Input.GetKey(right)) animator.SetBool("isWalking", true);
        else animator.SetBool("isWalking", false);

        if (Input.GetKey(left))
        {
            sr.flipX = true;
            pos.x -= direction;
        }
        if (Input.GetKey(right))
        {
            sr.flipX = false;
            pos.x += direction;
        }
        transform.position = pos;
    }
}
