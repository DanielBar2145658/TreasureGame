using UnityEngine;

public class PauseMenuManager : MonoBehaviour
{
    public GameObject pauseMenu;

    private void Start()
    {
        ResumeGame(); // Make sure the game is not paused when it starts
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePauseMenu();
        }
    }

    public void TogglePauseMenu()
    {
        if (pauseMenu.activeSelf)
        {
            ResumeGame();
        }
        else
        {
            PauseGame();
        }
    }

    private void PauseGame()
    {
        Time.timeScale = 0f; // Set the time scale to 0 to pause the game
        pauseMenu.SetActive(true);
    }

    private void ResumeGame()
    {
        Time.timeScale = 1f; // Set the time scale back to 1 to resume the game
        pauseMenu.SetActive(false);
    }
}