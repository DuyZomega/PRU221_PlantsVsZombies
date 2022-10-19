using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathManager : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Zombie")
        {
            //Ending Code here
            UnityEditor.EditorApplication.isPlaying = false;
            Application.Quit();
            Debug.Log("Died!");
        }
    }
}
