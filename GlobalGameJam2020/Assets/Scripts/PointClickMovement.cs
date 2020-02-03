using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointClickMovement : MonoBehaviour
{
    [SerializeField]
    float speed;

    public static Vector3 hitPos;
    public static Quaternion angle;

    Vector2 direction;
    Animator anim;
    Rigidbody2D rb;
    int x;
    int y;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        transform.position = new Vector3(0, 0, -1);
    }

    // Update is called once per frame
    void Update()
    {
        

        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //RaycastHit hit;

        AnimationDirections();

        if (Input.GetMouseButton(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit)
            {
                hitPos = hit.point;
                direction = hitPos - transform.position;
                angle = Quaternion.AngleAxis(Mathf.Atan2(-direction.normalized.x, direction.normalized.y) * Mathf.Rad2Deg, Vector3.forward);
            }

            anim.SetBool("isMoving", true);
        }

        hitPos.z = -1.0f;
        
        transform.position = Vector2.MoveTowards(transform.position, hitPos, speed);

        if (Vector2.Distance(transform.position, hitPos) < 0.1f)
            anim.SetBool("isMoving", false);
            

        anim.SetFloat("X", x);
        anim.SetFloat("Y", y);
    }

    void AnimationDirections() 
    {
        /*x = (transform.position.x < hitPos.x) ? -1 : -1;
        y = (transform.position.y < hitPos.y) ? -2 : 2;*/

        if (transform.position.x < hitPos.x)
            x = -1;
        else
            x = 1;

        if (transform.position.y < hitPos.y)
            y = -2;
        else
            y = 2;
    }
}
