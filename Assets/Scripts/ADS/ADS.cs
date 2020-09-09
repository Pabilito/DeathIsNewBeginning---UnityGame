using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class ADS : MonoBehaviour
{
    string gameId = "3769625";
    string bannerID = "Banner1";
    bool testMode = false;

    public bool bombardWithAd = false;
    string videoID = "rewardedVideo";

    void Start()
    {
        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
        Advertisement.Initialize(gameId, testMode);
        StartCoroutine(ShowBannerWhenInitialized());
        if (bombardWithAd)
        {
            StartCoroutine(BombardWithVideoWhenReady());
        }
    }

    IEnumerator ShowBannerWhenInitialized()
    {
        while (!Advertisement.isInitialized)
        {
            yield return new WaitForSeconds(0.5f);
        }
        Advertisement.Banner.Show(bannerID);
    }

    IEnumerator BombardWithVideoWhenReady()
    {
        while (!Advertisement.IsReady(videoID))
        {
            yield return new WaitForSeconds(0.5f);
        }
        Advertisement.Show(videoID);
    }
}
