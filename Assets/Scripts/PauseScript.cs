using UnityEngine;

public class PauseScript : MonoBehaviour
{
    private static bool isPaused = false;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }

        if (Input.GetKey("escape")) { Application.Quit(); }
    }

    

    public void ResumeGame()
    {   
        Time.timeScale = 1;
        isPaused = false;
    }

    void PauseGame()
    {
        Time.timeScale = 0;
        isPaused = true;
    }

    public bool getIsPaused() { return isPaused; }
    public bool setIsPaused(bool p)
    {
        isPaused = p;
        ResumeGame();
        return isPaused;
    }
}
