using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundOnOff : MonoBehaviour
{
    public Sprite mOn;
    public Sprite mOff;

    private void Start()
    {
        if (GlobalVariables.musinOn)
        {
            this.GetComponent<Image>().sprite = mOn;
        }
        else
        {
            this.GetComponent<Image>().sprite = mOff;
        }
    }

    public void OnSoundOnOff()
    {
        if (GlobalVariables.musinOn)
        {
            GlobalSoundManager.instance.GetComponent<AudioSource>().Pause();
            this.GetComponent<Image>().sprite = mOff;
        }
        else
        {
            this.GetComponent<Image>().sprite = mOn;
            GlobalSoundManager.instance.GetComponent<AudioSource>().UnPause();
        }
        GlobalVariables.musinOn = !GlobalVariables.musinOn;
    } 
}
