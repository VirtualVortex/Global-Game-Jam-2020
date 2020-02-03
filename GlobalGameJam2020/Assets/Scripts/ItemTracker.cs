using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ItemTracker : MonoBehaviour
{
    [SerializeField]
    Transform arrowAxis;
    [SerializeField]
    Transform Rover;
    [SerializeField]
    AudioClip audio;

    AudioSource audiosouce;

    Vector2 direction;
    Quaternion angle;
    List<Vector3> itemPoss = new List<Vector3>();
    int randomElement;

    // Start is called before the first frame update
    void Start()
    {
        itemPoss.Clear();
        StoreItemData[] items = GameObject.FindObjectsOfType<StoreItemData>();

        foreach (StoreItemData item in items)
        {
            itemPoss.Add(item.transform.position);
        }

        randomElement = Random.Range(0, itemPoss.Count);

        audiosouce = GetComponent<AudioSource>();

        foreach (Vector3 pos in itemPoss) 
        {
            Debug.Log(pos);
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (itemPoss.Count > 0) 
        {
            if (Vector2.Distance(transform.position, itemPoss[randomElement]) > 10)
            {
                arrowAxis.gameObject.SetActive(true);
                ArrowDirection(itemPoss[randomElement]);
            }
            else if (Vector2.Distance(transform.position, itemPoss[randomElement]) < 10)
            {
                arrowAxis.gameObject.SetActive(false);
            }  
        }


        if(itemPoss.Count <= 0)
        {
            randomElement = 0;
            itemPoss.Add(Rover.position);
        }

    }

    void OnCollisionEnter2D(Collision2D collision) 
    {

        if (collision.transform.tag.Contains("Item"))
        {
            itemPoss.Remove(collision.transform.position);
            randomElement = Random.Range(0, itemPoss.Count);
        }
    }

    void ArrowDirection(Vector3 pos) 
    {
        direction = pos - transform.position;
        angle = Quaternion.AngleAxis(Mathf.Atan2(-direction.normalized.x, direction.normalized.y) * Mathf.Rad2Deg, Vector3.forward);
        arrowAxis.rotation = Quaternion.Slerp(arrowAxis.rotation, angle, Time.deltaTime * 2);
    }
}
