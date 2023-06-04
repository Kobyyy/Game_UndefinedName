using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class settingsmenu : MonoBehaviour
{
    public AudioMixer MainMixer;
   public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
    public void SetAudioVolume(float volume)
    {
        MainMixer.SetFloat("volume", volume);

    }
   
}
