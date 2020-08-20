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

    private void Start()
    {
        starsTxt.GetComponent<Text>().text = GlobalVariables.instance.getLevelSum(1).ToString() + "/21";
    }

}
