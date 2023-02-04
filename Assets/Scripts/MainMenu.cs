using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        AudioManager.Instance.PlaySFX("Menu Click"); //button click
        SceneManager.LoadScene("coleAudioTest"); // SceneManager.LoadScene("Worldspace Name") // Alternate form of changing scenes
        Debug.Log("Play Button");
    }

    public void Quit()
    {
        
        Debug.Log("Quit Button");
        AudioManager.Instance.PlaySFX("Menu Click"); //button click
        Application.Quit();
        
    }

    public void Options()
    {
        Debug.Log("Options Press");
        AudioManager.Instance.PlaySFX("Menu Click"); //button click
        Debug.Log("Sound Played");
    }

}
