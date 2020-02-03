using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placeinspot : MonoBehaviour
{
    // Start is called before the first frame update

    [HideInInspector]
    public bool InPlace;
    void OnTriggerEnter2D(Collider2D col)

    {
        Debug.Log(col.transform.name);

        if (col.transform.tag.Contains("PickUpItem"))
        {
            if (transform.name.Contains(col.transform.name))
            {
                col.transform.position = transform.position;
                col.transform.parent = transform;
                InPlace = true;
                FindObjectOfType<MiniGameManager>().IncreaseCounter();
                FindObjectOfType<PickUp>().hasItem = false;
                col.transform.GetComponent<BoxCollider2D>().enabled = false;
            }

            if (InPlace)
            {
                col.transform.position = transform.position;
                transform.parent = null;
            }
        }
    }

}
