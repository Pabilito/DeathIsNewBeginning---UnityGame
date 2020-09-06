using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class ADSlevels0 : MonoBehaviour
{
    string videoID = "video";
    public bool giveAds = false;
    void Start()
    {
        if (giveAds)
        {
            StartCoroutine(ShowVideoWhenInitialized());
        }
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
