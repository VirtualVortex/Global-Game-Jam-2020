using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FixRover : MonoBehaviour
{
    [SerializeField]
    string scene;

    InventrySystem iS;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScene() 
    {
        if (iS.inventory.Count >= 3)
        {
            SceneManager.LoadScene(scene);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        iS = col.GetComponent<InventrySystem>();

        ChangeScene();
    }
}
