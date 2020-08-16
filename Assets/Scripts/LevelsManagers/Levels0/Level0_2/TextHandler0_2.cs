using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextHandler0_2 : MonoBehaviour
{
    public Text tutorialTxt;

    void Start()
    {
        tutorialTxt.GetComponent<Text>().text = "If you hit an obstacle you lose a life, but also you create a dead body on which you can jump";
    }

    private void Update()
    {
        if (this.GetComponent<HealthAndPointsManager>().getHealth() < 0)
        {
            tutorialTxt.GetComponent<Text>().text = "Try again clicking 'Retry'";
        }
        else if (this.GetComponent<HealthAndPointsManager>().getHealth() == 0)
        {
            tutorialTxt.GetComponent<Text>().text = "If you lose all lives you lose";
        }
        else if (this.transform.position.x > -2)
        {
            tutorialTxt.GetComponent<Text>().text = "Every time you touch a wall or dead body you get a jump reset";
        }
        else
        {
            tutorialTxt.GetComponent<Text>().text = "If you hit an obstacle you lose a life, but also you create a dead body on which you can jump";
        }
    }

}
