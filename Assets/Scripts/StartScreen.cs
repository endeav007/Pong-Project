using UnityEngine;
using UnityEngine.SceneManagement;


public class StartScreen : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void StartGameButton()
    {
        SceneManager.LoadScene("pong");
    }

    public void QuitGameButton()
    {
        Application.Quit();

    }

    void Update()
    {
        if (Input.GetKey("escape")) { Application.Quit(); }

    }
}
