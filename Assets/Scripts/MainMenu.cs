using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        
        SceneManager.LoadScene("Tanman Dungeon"); // SceneManager.LoadScene("Worldspace Name") // Alternate form of changing scenes
        Debug.Log("Play Button");
    }

    public void Quit()
    {
        
        Debug.Log("Quit Button");
        
        Application.Quit();
        
    }

    public void Options()
    {
        Debug.Log("Options Press");
        
        
    }

}
