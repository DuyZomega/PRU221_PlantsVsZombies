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
        PlayAudioClip();
        EditorApplication.isPlaying = false;
        Application.Quit();
    }
    void ChangeScene() 
    {
        PlayAudioClip();
        SceneManager.LoadSceneAsync(sceneID); 
    }
    void PlayAudioClip()
    {
        if (audioSource != null && audioClip!=null)
        {
            audioSource.clip = audioClip;
            audioSource.Play();
        }
    }
}
