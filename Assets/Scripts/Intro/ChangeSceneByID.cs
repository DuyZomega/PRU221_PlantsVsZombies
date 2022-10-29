using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeSceneByID : MonoBehaviour
{
    public int sceneID; 
    public Button loadSceneBtn;
    public AudioSource audioSource = null;
    public AudioClip audioClip;
    void Start() 
    {
        
        if (sceneID < 0 )
        {
            loadSceneBtn.onClick.AddListener(Exit);
        }
        
        loadSceneBtn.onClick.AddListener(ChangeScene);
    }
    void Exit()
    {
        PayAudioClip();
        //UnityEngine.EditorApplication.isPlaying = false;
        Application.Quit();
    }
    void ChangeScene() 
    {
        PayAudioClip();
        SceneManager.LoadSceneAsync(sceneID); 
    }
    void PayAudioClip()
    {
        if (audioSource != null && audioClip!=null)
        {
            audioSource.clip = audioClip;
            audioSource.Play();
        }
    }
}
