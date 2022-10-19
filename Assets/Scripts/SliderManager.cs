using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderManager : MonoBehaviour
{
    public Slider mainSlider;
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
            Debug.Log("PRogress Bar Quitted!!!");
            UnityEditor.EditorApplication.isPlaying = false;
            Application.Quit();
        }
    }
}
