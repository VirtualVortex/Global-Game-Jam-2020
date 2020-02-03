using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField]
    Text text;
    [SerializeField]
    float maxTime;
    [SerializeField]
    string sceneName;

    Animator anim;

    float timer;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (maxTime >= 0.0f)
        {
            timer = maxTime -= 0.01f;
        }
        else if(timer <= 0.0f)
        {
            maxTime = 0.0f;
            anim.SetBool("outOfTime", true);
        }

        text.text = timer.ToString();


    }

    public void ChangeScene() 
    {
        SceneManager.LoadScene(sceneName);
    }
}
