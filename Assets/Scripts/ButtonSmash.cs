using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class ButtonSmash : MonoBehaviour {

    public void ARScene()
    {
        SceneManager.LoadScene(1);
    }
    public void Physics()
    {
        SceneManager.LoadScene(2);
    }
    public void Chemistry()
    {
        SceneManager.LoadScene(3);
    }
    public void Biology()
    {
        SceneManager.LoadScene(4);
    }
    public void Options()
    {
        SceneManager.LoadScene(5);
    }
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exited");
        //Remove this before publishing the app
    }
    public void Home()
    {
        SceneManager.LoadScene(0);
    }
    public void contact()
    {
        SceneManager.LoadScene(7);
    }
    public void Infoscene()
    {
        SceneManager.LoadScene(6);
    }
    public void donatescene ()
    {
        SceneManager.LoadScene(8);
    }
    public void ourteamscene()
    {
        SceneManager.LoadScene(9);
    }

}
