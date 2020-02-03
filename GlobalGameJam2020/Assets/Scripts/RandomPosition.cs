using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour
{
    [SerializeField]
    Transform[] items;
    [SerializeField]
    float radius;

    // Start is called before the first frame update
    void Awake() 
    {
        for (int i = 0; i < items.Length - 1; i++)
        {
            items[i].position = Random.insideUnitCircle * radius;
        }
    }
}
