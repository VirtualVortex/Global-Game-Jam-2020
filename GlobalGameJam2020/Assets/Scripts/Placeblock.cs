using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placeblock : MonoBehaviour
{
    [SerializeField]
    GameObject Object;
    [SerializeField]
    float distFromPlayer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Vector2 direction = PointClickMovement.hitPos - transform.position;

            Instantiate(Object, (transform.up * distFromPlayer) + transform.position, PointClickMovement.angle);
        }
    }
}
