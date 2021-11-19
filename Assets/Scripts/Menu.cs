using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    // 1
    public void StartGame()
    {
        SceneManager.LoadScene("Battle");
    }
    // 2
    public void Quit()
    {
        Application.Quit();
    }
}
