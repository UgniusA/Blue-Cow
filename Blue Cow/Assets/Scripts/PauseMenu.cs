using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public bool paused;
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject quitConfirmMenu;
    [SerializeField] GameObject restartConfirmMenu;
    [SerializeField] GameObject OptionsButtonMenu;

    public void PauseGame() {/*
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;*/
        paused = true;
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
        quitConfirmMenu.SetActive(false);
        restartConfirmMenu.SetActive(false);
    }

    public void ResumeGame() {/*
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;*/
        paused = false;
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
        quitConfirmMenu.SetActive(false);
        restartConfirmMenu.SetActive(false);
    }

    public void RestartConfirmation() {
        restartConfirmMenu.SetActive(true);
        pauseMenu.SetActive(false);
    }

    public void RestartGame() {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
        quitConfirmMenu.SetActive(false);
        restartConfirmMenu.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GotoMainMenu() {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitConfirmation() {
        quitConfirmMenu.SetActive(true);
        pauseMenu.SetActive(false);
    }

    public void QuitGame() {
        Application.Quit();
    }
    
    public void OpenOptions()
    {
        OptionsButtonMenu.SetActive(true);
        pauseMenu.SetActive(false);
    }
}
