using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class ADSlevels0 : MonoBehaviour
{
    string videoID = "video";

    void Start()
    {
        StartCoroutine(ShowVideoWhenInitialized());
    }

    IEnumerator ShowVideoWhenInitialized()
    {
        while (!Advertisement.IsReady(videoID))
        {
            yield return new WaitForSeconds(0.5f);
        }
        Advertisement.Show(videoID);
    }
}
