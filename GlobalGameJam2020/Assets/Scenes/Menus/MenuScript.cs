using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuScript : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("MarsScene");
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void Options()
    {
        SceneManager.LoadScene("");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
