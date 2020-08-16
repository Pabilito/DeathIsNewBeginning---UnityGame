using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextHandler0_1 : MonoBehaviour
{
    public Text tutorialTxt;

    void Start()
    {
        tutorialTxt.GetComponent<Text>().text = "Tilt phone to move character";
    }

    private void Update()
    {
        if (this.transform.position.x > 18)
        {
            tutorialTxt.GetComponent<Text>().text = "";
        }
        else if (this.transform.position.x > 4)
        {
            tutorialTxt.GetComponent<Text>().text = "Collect at least one crystal to finish level";
        }
        else if (this.transform.position.x>-2)
        {
            tutorialTxt.GetComponent<Text>().text = "Tap to jump";
        }
        else
        {
            tutorialTxt.GetComponent<Text>().text = "Tilt phone to move character";
        }
    }

}
