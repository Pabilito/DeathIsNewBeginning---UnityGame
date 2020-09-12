using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Levels3Handler : MonoBehaviour
{
    public Image starsx_1_1;
    public Image starsx_1_2;
    public Image starsx_1_3;
    public Image starsx_2_1;
    public Image starsx_2_2;
    public Image starsx_2_3;
    public Image starsx_3_1;
    public Image starsx_3_2;
    public Image starsx_3_3;
    public Image starsx_4_1;
    public Image starsx_4_2;
    public Image starsx_4_3;
    public Image starsx_5_1;
    public Image starsx_5_2;
    public Image starsx_5_3;
    public Image starsx_6_1;
    public Image starsx_6_2;
    public Image starsx_6_3;
    public Image starsx_7_1;
    public Image starsx_7_2;
    public Image starsx_7_3;
    public Image starsx_8_1;
    public Image starsx_8_2;
    public Image starsx_8_3;

    public Text tx_1;
    public Text tx_2;
    public Text tx_3;
    public Text tx_4;
    public Text tx_5;
    public Text tx_6;
    public Text tx_7;
    public Text tx_8;
    public Text starsSum;

    public Button levelx_1;
    public Button levelx_2;
    public Button levelx_3;
    public Button levelx_4;
    public Button levelx_5;
    public Button levelx_6;
    public Button levelx_7;
    public Button levelx_8;

    private Color visible = new Vector4(1.0f, 1.0f, 1.0f, 1.0f);
    private Color invisible = new Vector4(0.3f, 0.4f, 0.6f, 0.3f);

    public Text starsTxt;
    public Text starsTxtmini1;
    public Text starsTxtmini2;
    public Text starsTxtmini3;

    public int page = 3;//chapter in the game

    private void Start()
    {
        checkStars();
        checkExtraLevels();
        string stars = GlobalVariables.instance.getLevelSum(page).ToString();
        starsTxt.GetComponent<Text>().text = stars + "/24";
        starsTxtmini1.GetComponent<Text>().text = "Bonus 1\n" + stars + "/5";
        starsTxtmini2.GetComponent<Text>().text = "Bonus 2\n" + stars + "/10";
        starsTxtmini3.GetComponent<Text>().text = "Bonus 3\n" + stars + "/15";
    }

    void checkExtraLevels()
    {
        int sum = GlobalVariables.instance.getLevelSum(page);
        if (sum < 5)
        {
            tx_6.color = Color.black;
            tx_7.color = Color.black;
            tx_8.color = Color.black;
            levelx_6.interactable = false;
            levelx_7.interactable = false;
            levelx_8.interactable = false;
        }
        else if (sum < 10)
        {
            tx_7.color = Color.black;
            tx_8.color = Color.black;
            levelx_7.interactable = false;
            levelx_8.interactable = false;
        }
        else if (sum < 15)
        {
            tx_8.color = Color.black;
            levelx_8.interactable = false;
        }
    }

    void checkStars()
    {
        if (GlobalVariables.instance.getLevelScore(5+(10*(page-1))) == 0)
        {
            levelx_1.interactable = false;
            tx_1.color = Color.black;
        }
        //assign stars
        switch (GlobalVariables.instance.getLevelScore(10 * page + 1))
        {
            case 0:
                tx_2.color = Color.black;
                levelx_2.interactable = false;
                starsx_1_1.color = invisible;
                starsx_1_2.color = invisible;
                starsx_1_3.color = invisible;
                break;
            case 1:
                starsx_1_1.color = visible;
                starsx_1_2.color = invisible;
                starsx_1_3.color = invisible;
                break;
            case 2:
                starsx_1_1.color = visible;
                starsx_1_2.color = visible;
                starsx_1_3.color = invisible;
                break;
            case 3:
                starsx_1_1.color = visible;
                starsx_1_2.color = visible;
                starsx_1_3.color = visible;
                break;
        }

        switch (GlobalVariables.instance.getLevelScore(10 * page + 2))
        {
            case 0:
                tx_3.color = Color.black;
                levelx_3.interactable = false;
                starsx_2_1.color = invisible;
                starsx_2_2.color = invisible;
                starsx_2_3.color = invisible;
                break;
            case 1:
                starsx_2_1.color = visible;
                starsx_2_2.color = invisible;
                starsx_2_3.color = invisible;
                break;
            case 2:
                starsx_2_1.color = visible;
                starsx_2_2.color = visible;
                starsx_2_3.color = invisible;
                break;
            case 3:
                starsx_2_1.color = visible;
                starsx_2_2.color = visible;
                starsx_2_3.color = visible;
                break;
        }

        switch (GlobalVariables.instance.getLevelScore(10 * page + 3))
        {
            case 0:
                tx_4.color = Color.black;
                levelx_4.interactable = false;
                starsx_3_1.color = invisible;
                starsx_3_2.color = invisible;
                starsx_3_3.color = invisible;
                break;
            case 1:
                starsx_3_1.color = visible;
                starsx_3_2.color = invisible;
                starsx_3_3.color = invisible;
                break;
            case 2:
                starsx_3_1.color = visible;
                starsx_3_2.color = visible;
                starsx_3_3.color = invisible;
                break;
            case 3:
                starsx_3_1.color = visible;
                starsx_3_2.color = visible;
                starsx_3_3.color = visible;
                break;
        }

        switch (GlobalVariables.instance.getLevelScore(10 * page + 4))
        {
            case 0:
                tx_5.color = Color.black;
                levelx_5.interactable = false;
                starsx_4_1.color = invisible;
                starsx_4_2.color = invisible;
                starsx_4_3.color = invisible;
                break;
            case 1:
                starsx_4_1.color = visible;
                starsx_4_2.color = invisible;
                starsx_4_3.color = invisible;
                break;
            case 2:
                starsx_4_1.color = visible;
                starsx_4_2.color = visible;
                starsx_4_3.color = invisible;
                break;
            case 3:
                starsx_4_1.color = visible;
                starsx_4_2.color = visible;
                starsx_4_3.color = visible;
                break;
        }
        switch (GlobalVariables.instance.getLevelScore(10 * page + 5))
        {
            case 0:
                starsx_5_1.color = invisible;
                starsx_5_2.color = invisible;
                starsx_5_3.color = invisible;
                break;
            case 1:
                starsx_5_1.color = visible;
                starsx_5_2.color = invisible;
                starsx_5_3.color = invisible;
                break;
            case 2:
                starsx_5_1.color = visible;
                starsx_5_2.color = visible;
                starsx_5_3.color = invisible;
                break;
            case 3:
                starsx_5_1.color = visible;
                starsx_5_2.color = visible;
                starsx_5_3.color = visible;
                break;
        }

        switch (GlobalVariables.instance.getLevelScore(10 * page + 6))
        {
            case 0:
                starsx_6_1.color = invisible;
                starsx_6_2.color = invisible;
                starsx_6_3.color = invisible;
                break;
            case 1:
                starsx_6_1.color = visible;
                starsx_6_2.color = invisible;
                starsx_6_3.color = invisible;
                break;
            case 2:
                starsx_6_1.color = visible;
                starsx_6_2.color = visible;
                starsx_6_3.color = invisible;
                break;
            case 3:
                starsx_6_1.color = visible;
                starsx_6_2.color = visible;
                starsx_6_3.color = visible;
                break;
        }

        switch (GlobalVariables.instance.getLevelScore(10 * page + 7))
        {
            case 0:
                starsx_7_1.color = invisible;
                starsx_7_2.color = invisible;
                starsx_7_3.color = invisible;
                break;
            case 1:
                starsx_7_1.color = visible;
                starsx_7_2.color = invisible;
                starsx_7_3.color = invisible;
                break;
            case 2:
                starsx_7_1.color = visible;
                starsx_7_2.color = visible;
                starsx_7_3.color = invisible;
                break;
            case 3:
                starsx_7_1.color = visible;
                starsx_7_2.color = visible;
                starsx_7_3.color = visible;
                break;
        }

        switch (GlobalVariables.instance.getLevelScore(10 * page + 8))
        {
            case 0:
                starsx_8_1.color = invisible;
                starsx_8_2.color = invisible;
                starsx_8_3.color = invisible;
                break;
            case 1:
                starsx_8_1.color = visible;
                starsx_8_2.color = invisible;
                starsx_8_3.color = invisible;
                break;
            case 2:
                starsx_8_1.color = visible;
                starsx_8_2.color = visible;
                starsx_8_3.color = invisible;
                break;
            case 3:
                starsx_8_1.color = visible;
                starsx_8_2.color = visible;
                starsx_8_3.color = visible;
                break;
        }
    }
}
