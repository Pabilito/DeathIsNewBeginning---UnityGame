using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class PlayButtonHandler : MonoBehaviour
{  
    void Start()
    {
        Application.targetFrameRate = 30;
    }

    public void OnPlay()
    {
        Advertisement.Banner.Hide();
        SceneManager.LoadScene(1);
    }
}
