using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameManager : MonoBehaviour
{
    [SerializeField]
    string endScene;

    int counter;

    // Update is called once per frame
    void Update()
    {
        if (counter >= 3)
            SceneManager.LoadScene(endScene);
    }

    public void IncreaseCounter() 
    {
        counter++;
    }
}
