using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextHandler0_3 : MonoBehaviour
{
    public Text tutorialTxt;

    void Start()
    {
        tutorialTxt.GetComponent<Text>().text = "Collect life to increase your current health";
    }

    private void Update()
    {
        if (this.transform.position.x > 10)
        {
            tutorialTxt.GetComponent<Text>().text = "Flying obstacles are destoryed when they hit the wall or dead body";
        }
        else if (this.transform.position.x > 3)
        {
            tutorialTxt.GetComponent<Text>().text = "Beware of flying obstacles";
        }
        else
        {
            tutorialTxt.GetComponent<Text>().text = "Collect life to increase your current health";
        }
    }

}
