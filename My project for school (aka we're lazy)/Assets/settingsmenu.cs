using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class settingsmenu : MonoBehaviour
{
    public AudioMixer mainMixer;
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
        mainMixer.SetFloat("Volume", volume);

    }
    public void BackFunction()
    {

    }
}
