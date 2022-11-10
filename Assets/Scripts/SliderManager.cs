using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class SliderManager : MonoBehaviour
{
    public GameObject WinGame;
    public Slider mainSlider;
    public static bool GameIsPause = false;
    void Start()
    {
        mainSlider.value = 0;
    }
    void Update()
    {
        EndGameProgressBar();
    }
    public void EndGameProgressBar()
    {
        if (mainSlider.value.Equals(6f))
        {
            Debug.Log(mainSlider.value.ToString());
            Debug.Log("Progress Bar Quitted!!!");
            WinGame.SetActive(true);
            Time.timeScale = 0f;
            GameIsPause = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
