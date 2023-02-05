using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class SoundManager 
{

    public enum Sound
    {
        enemyAttack,
        menuClick,
        playerMagic,
        hitNoise,
        bossDeath,
        bossShoot,
        levelMusic,
        
    }
    public static void PlaySound(Sound sound)
    {
        GameObject soundGameObject = new GameObject("Sound");
        AudioSource audioSource = soundGameObject.AddComponent<AudioSource>(); 
        audioSource.PlayOneShot(GetAudioClip(sound));
        
        
    }


   

    //private static bool CanPlaySound(Sound sound)
    //{
    //    switch (sound)
    //    {
    //        default:
    //            return true;

    //    }
    //}

    private static AudioClip GetAudioClip(Sound sound)
    {
        foreach (GameAssets.SoundAudioClip soundAudioClip in GameAssets.i.soundAudioClipArray) //SoundManager.PlaySound(SoundManager.Sound.SOUNDASSET);  
        {
            if (soundAudioClip.sound == sound)
            {
                return soundAudioClip.audioClip;
            }
        }
        Debug.Log("ERROR: Sound" + sound + " not found");
        return null;
    }

    
    

}
