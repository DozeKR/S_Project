using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Start_btn()
    {
        SceneManager.LoadScene("Stage01");
    }
    public void Exit_btn()
    {
        Application.Quit();
    }
}
