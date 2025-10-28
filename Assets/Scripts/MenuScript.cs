using UnityEngine;

public class MenuScipt : MonoBehaviour
{
    public GameObject pauseMenu;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public PauseScript p;
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (p.getIsPaused())
        {
            pauseMenu.SetActive(true);
            Debug.Log("Deteched pause!");
        }
        else
        {
            pauseMenu.SetActive(false);
            Debug.Log("Deteched pause!");
        }
    }

    public void ResumeButton()
    {
        p.setIsPaused(p.getIsPaused());
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
