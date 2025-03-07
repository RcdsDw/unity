using UnityEngine;

public class Piaf : MonoBehaviour
{
    public SlingShot slingshot;

    private bool isJoined;
    private Vector2 piaf_pos_or;
    private Vector2 piaf_pos_drag;

    private SpringJoint2D elastic;

    private LineRenderer piaf_l;
    private Rigidbody2D piaf_rb;
    private DistanceJoint2D piaf_dj;
    private SpringJoint2D piaf_sj;
    private Rigidbody2D ss_rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        piaf_rb = GetComponent<Rigidbody2D>();
        piaf_dj = GetComponent<DistanceJoint2D>();
        piaf_l = GetComponent<LineRenderer>();
        piaf_sj = GetComponent<SpringJoint2D>();
        ss_rb = slingshot.GetComponent<Rigidbody2D>();
        //isJoined = false;
    }

    // Update is called once per frame
    void Update()
    {
        piaf_l.SetPosition(0, slingshot.transform.position);
        piaf_l.SetPosition(1, transform.position);
    }

    private void OnMouseDown()
    {
        piaf_pos_or = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseDrag()
    {
        piaf_pos_drag = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        piaf_rb.MovePosition(piaf_pos_drag);
        piaf_rb.gravityScale = 0.5f;
        //piaf_dj.enabled = true;
        piaf_sj.enabled = true;

        Debug.Log(transform.position);
    }

    private void OnMouseUp()
    {
        //piaf_dj.enabled = false;
        piaf_sj.enabled = false;
        piaf_rb.AddForce(piaf_sj.reactionForce, ForceMode2D.Impulse);
    }

        //if (!isJoined)
        //{
        //    addElastic();
        //}
    //private void addElastic()
    //{
    //    isJoined = true;
    //    elastic = gameObject.AddComponent<SpringJoint2D>();
    //    elastic.connectedBody = ss_rb;
    //    elastic.distance = 3;
    //    elastic.frequency = 0.5f;
    //    elastic.dampingRatio = 1;
    //}
}
