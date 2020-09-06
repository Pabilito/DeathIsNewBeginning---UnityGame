using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Levels2Handler : MonoBehaviour
{
    public Image stars2_1_1;
    public Image stars2_1_2;
    public Image stars2_1_3;
    public Image stars2_2_1;
    public Image stars2_2_2;
    public Image stars2_2_3;
    public Image stars2_3_1;
    public Image stars2_3_2;
    public Image stars2_3_3;
    public Image stars2_4_1;
    public Image stars2_4_2;
    public Image stars2_4_3;
    public Image stars2_5_1;
    public Image stars2_5_2;
    public Image stars2_5_3;
    public Image stars2_6_1;
    public Image stars2_6_2;
    public Image stars2_6_3;
    public Image stars2_7_1;
    public Image stars2_7_2;
    public Image stars2_7_3;
    public Image stars2_8_1;
    public Image stars2_8_2;
    public Image stars2_8_3;

    public Text t2_1;
    public Text t2_2;
    public Text t2_3;
    public Text t2_4;
    public Text t2_5;
    public Text t2_6;
    public Text t2_7;
    public Text t2_8;
    public Text starsSum;

    public Button level2_1;
    public Button level2_2;
    public Button level2_3;
    public Button level2_4;
    public Button level2_5;
    public Button level2_6;
    public Button level2_7;
    public Button level2_8;

    private Color visible = new Vector4(1.0f, 1.0f, 1.0f, 1.0f);
    private Color invisible = new Vector4(0.3f, 0.4f, 0.6f, 0.3f);

    public Text starsTxt;
    public Text starsTxtmini1;
    public Text starsTxtmini2;
    public Text starsTxtmini3;

    private void Start()
    {
        checkStars();
        checkExtraLevels();
        string stars = GlobalVariables.instance.getLevelSum(2).ToString();
        starsTxt.GetComponent<Text>().text = stars + "/24";
        starsTxtmini1.GetComponent<Text>().text = "Bonus 1\n" + stars + "/5";
        starsTxtmini2.GetComponent<Text>().text = "Bonus 2\n" + stars + "/10";
        starsTxtmini3.GetComponent<Text>().text = "Bonus 3\n" + stars + "/15";
    }

    void checkExtraLevels()
    {
        int sum = GlobalVariables.instance.getLevelSum(2);
        if (sum < 5)
        {
            t2_6.color = Color.black;
            t2_7.color = Color.black;
            t2_8.color = Color.black;
            level2_6.interactable = false;
            level2_7.interactable = false;
            level2_8.interactable = false;
        }
        else if (sum < 10)
        {
            t2_7.color = Color.black;
            t2_8.color = Color.black;
            level2_7.interactable = false;
            level2_8.interactable = false;
        }
        else if (sum < 15)
        {
            t2_8.color = Color.black;
            level2_8.interactable = false;
        }
    }

    void checkStars()
    {
        if (GlobalVariables.instance.getLevelScore(15) == 0)
        {
            level2_1.interactable = false;
            t2_1.color = Color.black;
        }
        //assign stars
        switch (GlobalVariables.instance.getLevelScore(21))
        {
            case 0:
                t2_2.color = Color.black;
                level2_2.interactable = false;
                stars2_1_1.color = invisible;
                stars2_1_2.color = invisible;
                stars2_1_3.color = invisible;
                break;
            case 1:
                stars2_1_1.color = visible;
                stars2_1_2.color = invisible;
                stars2_1_3.color = invisible;
                break;
            case 2:
                stars2_1_1.color = visible;
                stars2_1_2.color = visible;
                stars2_1_3.color = invisible;
                break;
            case 3:
                stars2_1_1.color = visible;
                stars2_1_2.color = visible;
                stars2_1_3.color = visible;
                break;
        }

        switch (GlobalVariables.instance.getLevelScore(22))
        {
            case 0:
                t2_3.color = Color.black;
                level2_3.interactable = false;
                stars2_2_1.color = invisible;
                stars2_2_2.color = invisible;
                stars2_2_3.color = invisible;
                break;
            case 1:
                stars2_2_1.color = visible;
                stars2_2_2.color = invisible;
                stars2_2_3.color = invisible;
                break;
            case 2:
                stars2_2_1.color = visible;
                stars2_2_2.color = visible;
                stars2_2_3.color = invisible;
                break;
            case 3:
                stars2_2_1.color = visible;
                stars2_2_2.color = visible;
                stars2_2_3.color = visible;
                break;
        }

        switch (GlobalVariables.instance.getLevelScore(23))
        {
            case 0:
                t2_4.color = Color.black;
                level2_4.interactable = false;
                stars2_3_1.color = invisible;
                stars2_3_2.color = invisible;
                stars2_3_3.color = invisible;
                break;
            case 1:
                stars2_3_1.color = visible;
                stars2_3_2.color = invisible;
                stars2_3_3.color = invisible;
                break;
            case 2:
                stars2_3_1.color = visible;
                stars2_3_2.color = visible;
                stars2_3_3.color = invisible;
                break;
            case 3:
                stars2_3_1.color = visible;
                stars2_3_2.color = visible;
                stars2_3_3.color = visible;
                break;
        }

        switch (GlobalVariables.instance.getLevelScore(24))
        {
            case 0:
                t2_5.color = Color.black;
                level2_5.interactable = false;
                stars2_4_1.color = invisible;
                stars2_4_2.color = invisible;
                stars2_4_3.color = invisible;
                break;
            case 1:
                stars2_4_1.color = visible;
                stars2_4_2.color = invisible;
                stars2_4_3.color = invisible;
                break;
            case 2:
                stars2_4_1.color = visible;
                stars2_4_2.color = visible;
                stars2_4_3.color = invisible;
                break;
            case 3:
                stars2_4_1.color = visible;
                stars2_4_2.color = visible;
                stars2_4_3.color = visible;
                break;
        }
        switch (GlobalVariables.instance.getLevelScore(25))
        {
            case 0:
                stars2_5_1.color = invisible;
                stars2_5_2.color = invisible;
                stars2_5_3.color = invisible;
                break;
            case 1:
                stars2_5_1.color = visible;
                stars2_5_2.color = invisible;
                stars2_5_3.color = invisible;
                break;
            case 2:
                stars2_5_1.color = visible;
                stars2_5_2.color = visible;
                stars2_5_3.color = invisible;
                break;
            case 3:
                stars2_5_1.color = visible;
                stars2_5_2.color = visible;
                stars2_5_3.color = visible;
                break;
        }

        switch (GlobalVariables.instance.getLevelScore(26))
        {
            case 0:
                stars2_6_1.color = invisible;
                stars2_6_2.color = invisible;
                stars2_6_3.color = invisible;
                break;
            case 1:
                stars2_6_1.color = visible;
                stars2_6_2.color = invisible;
                stars2_6_3.color = invisible;
                break;
            case 2:
                stars2_6_1.color = visible;
                stars2_6_2.color = visible;
                stars2_6_3.color = invisible;
                break;
            case 3:
                stars2_6_1.color = visible;
                stars2_6_2.color = visible;
                stars2_6_3.color = visible;
                break;
        }

        switch (GlobalVariables.instance.getLevelScore(27))
        {
            case 0:
                stars2_7_1.color = invisible;
                stars2_7_2.color = invisible;
                stars2_7_3.color = invisible;
                break;
            case 1:
                stars2_7_1.color = visible;
                stars2_7_2.color = invisible;
                stars2_7_3.color = invisible;
                break;
            case 2:
                stars2_7_1.color = visible;
                stars2_7_2.color = visible;
                stars2_7_3.color = invisible;
                break;
            case 3:
                stars2_7_1.color = visible;
                stars2_7_2.color = visible;
                stars2_7_3.color = visible;
                break;
        }

        switch (GlobalVariables.instance.getLevelScore(28))
        {
            case 0:
                stars2_8_1.color = invisible;
                stars2_8_2.color = invisible;
                stars2_8_3.color = invisible;
                break;
            case 1:
                stars2_8_1.color = visible;
                stars2_8_2.color = invisible;
                stars2_8_3.color = invisible;
                break;
            case 2:
                stars2_8_1.color = visible;
                stars2_8_2.color = visible;
                stars2_8_3.color = invisible;
                break;
            case 3:
                stars2_8_1.color = visible;
                stars2_8_2.color = visible;
                stars2_8_3.color = visible;
                break;
        }
    }
}
