using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextHandler0_3 : MonoBehaviour
{
    public Text tutorialTxt;

    void Start()
    {
        tutorialTxt.GetComponent<Text>().text = "To be done";
    }

    private void Update()
    {
        if (this.GetComponent<HealthAndPointsManager>().getHealth() < 0)
        {
            tutorialTxt.GetComponent<Text>().text = "";
        }
        else if (this.GetComponent<HealthAndPointsManager>().getHealth() == 0)
        {
            tutorialTxt.GetComponent<Text>().text = "";
        }
        else if (this.transform.position.x > -2)
        {
            tutorialTxt.GetComponent<Text>().text = "";
        }
        else
        {
            tutorialTxt.GetComponent<Text>().text = "Level in development";
        }
    }

}
