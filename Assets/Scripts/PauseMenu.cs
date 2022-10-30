using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[System.Serializable]
public class PauseMenu : MonoBehaviour
{
    public Button yourButton;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
    pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
        Cursor.lockState = CursorLockMode.None;
    }
    // Start is called before the first frame update
    public static bool GameIsPause = false;

    [SerializeField]
    private GameObject

            pauseMenuUI,
            optionMenu;

    [SerializeField]

    public void RestartButton()
    {
        SceneManager.LoadScene("MainScene");
        Time.timeScale = 1f;
        GameIsPause = false;
        Cursor.lockState = CursorLockMode.None;
    }

    private GameObject mainMenu;


    // Update is called once per frame

    public void Resume()
    {
        Cursor.lockState = CursorLockMode.None;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;

    }

    public void Quit()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    public void Pause()
    {

        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void Return()
    {
        SceneManager.LoadScene("MenuScene");
        Time.timeScale = 1f;
        GameIsPause = false;
        Cursor.lockState = CursorLockMode.None;
    }

    public void Options()
    {
        if (GameIsPause)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0f;
            GameIsPause = true;

        }
        else
        {
            Resume();
        }
    }
}
