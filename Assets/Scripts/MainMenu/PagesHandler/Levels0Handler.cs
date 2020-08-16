using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Levels0Handler : MonoBehaviour
{
    public Image stars0_1;
    public Image stars0_2;
    public Image stars0_3;

    public Text t0_2;
    public Text t0_3;

    public Button level0_2;
    public Button level0_3;

    private Color visible = new Vector4(1.0f, 1.0f, 1.0f, 1.0f);
    private Color invisible = new Vector4(0.3f, 0.4f, 0.6f, 0.3f);

    void Start() //check interactability
    {
        if (GlobalVariables.instance.getLevelScore(3) == 1)
        {
            stars0_3.color = visible;
            stars0_2.color = visible;
            stars0_1.color = visible;
        }
        else if (GlobalVariables.instance.getLevelScore(2) == 1)
        {
            stars0_3.color = invisible;
            stars0_2.color = visible;
            stars0_1.color = visible;
        }
        else if (GlobalVariables.instance.getLevelScore(1) == 1)
        {
            stars0_3.color = invisible;
            stars0_2.color = invisible;
            stars0_1.color = visible;
            level0_3.interactable = false;
            t0_3.color = Color.red;
        }
        else
        {
            stars0_3.color = invisible;
            stars0_2.color = invisible;
            stars0_1.color = invisible;
            level0_3.interactable = false;
            level0_2.interactable = false;
            t0_3.color = Color.red;
            t0_2.color = Color.red;
        }
    }
}
