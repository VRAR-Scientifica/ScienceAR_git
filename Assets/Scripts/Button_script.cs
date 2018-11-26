using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Button_script : MonoBehaviour {

    public void ButtonCLick()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Exited Game");
    }

    public void physics()
    {
        SceneManager.LoadScene(2);
    }
    public void chemistry()
    {
        SceneManager.LoadScene(3);
    }
    public void biology()
    {
        SceneManager.LoadScene(5);
    }
}
