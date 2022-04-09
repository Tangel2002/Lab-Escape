using UnityEngine;

public class Menu : MonoBehaviour
{
    bool paused = false;
    public Canvas pauseCanv;


    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            pauseMenu();
        }
    }
    public void pauseMenu()
    {
        if (!paused)
        {
            pauseCanv.gameObject.SetActive(true);
            Time.timeScale = 0;

        }
        else
        {
            Time.timeScale = 1;
            pauseCanv.gameObject.SetActive(false);
        }

        paused = !paused;
    }


    public void exit()
    {
        Application.Quit();
    }
}
