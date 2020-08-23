using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RewardedAds : MonoBehaviour
{
    string videoID = "rewardedVideo";
    public Button adButton;
    public Text adText;

    void Start()
    {
        adButton.interactable = false;
        adText.GetComponent<Text>().text = "Ad already watched";
        if (!GlobalVariables.instance.extraLifeOn)
        {
            adText.GetComponent<Text>().text = "Watch ad to get extra life";
            StartCoroutine(ShowVideoAvailability());
        }      
    }

    IEnumerator ShowVideoAvailability()
    {
        while (!Advertisement.IsReady(videoID))
        {
            yield return new WaitForSeconds(0.5f);
        }
        adButton.interactable = true;
    }


    public void onAdForExtraLife()
    {
        GlobalVariables.instance.extraLifeOn = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Advertisement.Show(videoID);
    }
}
