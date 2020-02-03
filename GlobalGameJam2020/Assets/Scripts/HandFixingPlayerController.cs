using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandFixingPlayerController : MonoBehaviour
{
    public GameObject LeftHand;
    public GameObject RightHand;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LeftMove();
        RightMove();
    }

    void LeftMove()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        LeftHand.transform.position += new Vector3(x, y, 0) * speed;
    }

    void RightMove()
    {
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");
        RightHand.transform.position += new Vector3(x, y, 0) * speed;
    }

}
