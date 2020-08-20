using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Levels1Handler : MonoBehaviour
{
    public Image stars1_1_1;
    public Image stars1_1_2;
    public Image stars1_1_3;
    public Image stars1_2_1;
    public Image stars1_2_2;
    public Image stars1_2_3;
    public Image stars1_3_1;
    public Image stars1_3_2;
    public Image stars1_3_3;
    public Image stars1_4_1;
    public Image stars1_4_2;
    public Image stars1_4_3;
    public Image stars1_5_1;
    public Image stars1_5_2;
    public Image stars1_5_3;
    public Image stars1_6_1;
    public Image stars1_6_2;
    public Image stars1_6_3;
    public Image stars1_7_1;
    public Image stars1_7_2;
    public Image stars1_7_3;
    public Image stars1_8_1;
    public Image stars1_8_2;
    public Image stars1_8_3;

    public Text t1_1;
    public Text t1_2;
    public Text t1_3;
    public Text t1_4;
    public Text t1_5;
    public Text t1_6;
    public Text t1_7;
    public Text t1_8;
    public Text starsSum;

    public Button level1_1;
    public Button level1_2;
    public Button level1_3;
    public Button level1_4;
    public Button level1_5;
    public Button level1_6;
    public Button level1_7;
    public Button level1_8;

    private Color visible = new Vector4(1.0f, 1.0f, 1.0f, 1.0f);
    private Color invisible = new Vector4(0.3f, 0.4f, 0.6f, 0.3f);

    public Text starsTxt;
    public Text starsTxtmini1;
    public Text starsTxtmini2;
    public Text starsTxtmini3;

    private void Start()
    {
        checkStars();
        string stars = GlobalVariables.instance.getLevelSum(1).ToString();
        starsTxt.GetComponent<Text>().text = stars + "/21";
        starsTxtmini1.GetComponent<Text>().text = "Bonus 1\n"+ stars + "/5";
        starsTxtmini2.GetComponent<Text>().text = "Bonus 2\n" + stars + "/10";
        starsTxtmini3.GetComponent<Text>().text = "Bonus 2\n" + stars + "/15";
    }

    void checkStars()
    {
        //assign stars
        switch (GlobalVariables.instance.getLevelScore(11))
        {
            case 0:
                stars1_1_1.color = invisible;
                stars1_1_2.color = invisible;
                stars1_1_3.color = invisible;
                break;
            case 1:
                stars1_1_1.color = visible;
                stars1_1_2.color = invisible;
                stars1_1_3.color = invisible;
                break;
            case 2:
                stars1_1_1.color = visible;
                stars1_1_2.color = visible;
                stars1_1_3.color = invisible;
                break;
            case 3:
                stars1_1_1.color = visible;
                stars1_1_2.color = visible;
                stars1_1_3.color = visible;
                break;
        }

        switch (GlobalVariables.instance.getLevelScore(12))
        {
            case 0:
                stars1_2_1.color = invisible;
                stars1_2_2.color = invisible;
                stars1_2_3.color = invisible;
                break;
            case 1:
                stars1_2_1.color = visible;
                stars1_2_2.color = invisible;
                stars1_2_3.color = invisible;
                break;
            case 2:
                stars1_2_1.color = visible;
                stars1_2_2.color = visible;
                stars1_2_3.color = invisible;
                break;
            case 3:
                stars1_2_1.color = visible;
                stars1_2_2.color = visible;
                stars1_2_3.color = visible;
                break;
        }

        switch (GlobalVariables.instance.getLevelScore(13))
        {
            case 0:
                stars1_3_1.color = invisible;
                stars1_3_2.color = invisible;
                stars1_3_3.color = invisible;
                break;
            case 1:
                stars1_3_1.color = visible;
                stars1_3_2.color = invisible;
                stars1_3_3.color = invisible;
                break;
            case 2:
                stars1_3_1.color = visible;
                stars1_3_2.color = visible;
                stars1_3_3.color = invisible;
                break;
            case 3:
                stars1_3_1.color = visible;
                stars1_3_2.color = visible;
                stars1_3_3.color = visible;
                break;
        }

        switch (GlobalVariables.instance.getLevelScore(14))
        {
            case 0:
                stars1_4_1.color = invisible;
                stars1_4_2.color = invisible;
                stars1_4_3.color = invisible;
                break;
            case 1:
                stars1_4_1.color = visible;
                stars1_4_2.color = invisible;
                stars1_4_3.color = invisible;
                break;
            case 2:
                stars1_4_1.color = visible;
                stars1_4_2.color = visible;
                stars1_4_3.color = invisible;
                break;
            case 3:
                stars1_4_1.color = visible;
                stars1_4_2.color = visible;
                stars1_4_3.color = visible;
                break;
        }
        switch (GlobalVariables.instance.getLevelScore(15))
        {
            case 0:
                stars1_5_1.color = invisible;
                stars1_5_2.color = invisible;
                stars1_5_3.color = invisible;
                break;
            case 1:
                stars1_5_1.color = visible;
                stars1_5_2.color = invisible;
                stars1_5_3.color = invisible;
                break;
            case 2:
                stars1_5_1.color = visible;
                stars1_5_2.color = visible;
                stars1_5_3.color = invisible;
                break;
            case 3:
                stars1_5_1.color = visible;
                stars1_5_2.color = visible;
                stars1_5_3.color = visible;
                break;
        }

        switch (GlobalVariables.instance.getLevelScore(16))
        {
            case 0:
                stars1_6_1.color = invisible;
                stars1_6_2.color = invisible;
                stars1_6_3.color = invisible;
                break;
            case 1:
                stars1_6_1.color = visible;
                stars1_6_2.color = invisible;
                stars1_6_3.color = invisible;
                break;
            case 2:
                stars1_6_1.color = visible;
                stars1_6_2.color = visible;
                stars1_6_3.color = invisible;
                break;
            case 3:
                stars1_6_1.color = visible;
                stars1_6_2.color = visible;
                stars1_6_3.color = visible;
                break;
        }

        switch (GlobalVariables.instance.getLevelScore(17))
        {
            case 0:
                stars1_7_1.color = invisible;
                stars1_7_2.color = invisible;
                stars1_7_3.color = invisible;
                break;
            case 1:
                stars1_7_1.color = visible;
                stars1_7_2.color = invisible;
                stars1_7_3.color = invisible;
                break;
            case 2:
                stars1_7_1.color = visible;
                stars1_7_2.color = visible;
                stars1_7_3.color = invisible;
                break;
            case 3:
                stars1_7_1.color = visible;
                stars1_7_2.color = visible;
                stars1_7_3.color = visible;
                break;
        }

        switch (GlobalVariables.instance.getLevelScore(18))
        {
            case 0:
                stars1_8_1.color = invisible;
                stars1_8_2.color = invisible;
                stars1_8_3.color = invisible;
                break;
            case 1:
                stars1_8_1.color = visible;
                stars1_8_2.color = invisible;
                stars1_8_3.color = invisible;
                break;
            case 2:
                stars1_8_1.color = visible;
                stars1_8_2.color = visible;
                stars1_8_3.color = invisible;
                break;
            case 3:
                stars1_8_1.color = visible;
                stars1_8_2.color = visible;
                stars1_8_3.color = visible;
                break;
        }
    }

}
