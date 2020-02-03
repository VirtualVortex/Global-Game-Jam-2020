using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{

    public bool hasItem;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.transform.tag.Contains("PickUpItem") && !hasItem)
        {
            col.transform.position = transform.position;
            col.transform.parent = transform;
            hasItem = true;
        }
    }


}

