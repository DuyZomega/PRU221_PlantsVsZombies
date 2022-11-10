using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathManager : MonoBehaviour
{
    public GameObject GameOver;
    public static bool GameIsPause = false;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Zombie")
        {
            //Ending Code here
            GameOver.SetActive(true);
            Time.timeScale = 0f;
            GameIsPause = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
