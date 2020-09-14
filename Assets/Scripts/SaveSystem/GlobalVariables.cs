using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GlobalVariables : MonoBehaviour
{
    public static GlobalVariables instance { set; get; }

    public GameObject SaveMan;

    static int starsLevel0_1 = 0;
    static int starsLevel0_2 = 0;
    static int starsLevel0_3 = 0;

    static int starsLevel1_1 = 0;
    static int starsLevel1_2 = 0;
    static int starsLevel1_3 = 0;
    static int starsLevel1_4 = 0;
    static int starsLevel1_5 = 0;
    static int starsLevel1_6 = 0;
    static int starsLevel1_7 = 0;
    static int starsLevel1_8 = 0;
    static int sumLevels1;

    static int starsLevel2_1 = 0;
    static int starsLevel2_2 = 0;
    static int starsLevel2_3 = 0;
    static int starsLevel2_4 = 0;
    static int starsLevel2_5 = 0;
    static int starsLevel2_6 = 0;
    static int starsLevel2_7 = 0;
    static int starsLevel2_8 = 0;
    static int sumLevels2;

    static int starsLevel3_1 = 0;
    static int starsLevel3_2 = 0;
    static int starsLevel3_3 = 0;
    static int starsLevel3_4 = 0;
    static int starsLevel3_5 = 0;
    static int starsLevel3_6 = 0;
    static int starsLevel3_7 = 0;
    static int starsLevel3_8 = 0;
    static int sumLevels3;

    public static bool musinOn = true;
    public static bool extraLifeOn = false;
    public bool cameraSwap = false;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject); //can be accessed anywhere
        instance = this;
    }

    void Start()
    {
        Load();
        calculateSums();
    }

    void calculateSums()
    {
        sumLevels1 = starsLevel1_1 + starsLevel1_2 + starsLevel1_3 + starsLevel1_4 + starsLevel1_5 + starsLevel1_6 + starsLevel1_7 + starsLevel1_8;
        sumLevels2 = starsLevel2_1 + starsLevel2_2 + starsLevel2_3 + starsLevel2_4 + starsLevel2_5 + starsLevel2_6 + starsLevel2_7 + starsLevel2_8;
        sumLevels3 = starsLevel3_1 + starsLevel3_2 + starsLevel3_3 + starsLevel3_4 + starsLevel3_5 + starsLevel3_6 + starsLevel3_7 + starsLevel3_8;
    }

    public int getLevelSum(int levels)
    {
        calculateSums();
        switch (levels)
        {
            case 1:
                return sumLevels1;
            case 2:
                return sumLevels2;
            case 3:
                return sumLevels3;
        }
        return -1; //error
    }


    public int getLevelScore(int level)
    {
        switch (level)
        {
            case 1:
                return starsLevel0_1;
            case 2:
                return starsLevel0_2;
            case 3:
                return starsLevel0_3;
            case 11:
                return starsLevel1_1;
            case 12:
                return starsLevel1_2;
            case 13:
                return starsLevel1_3;
            case 14:
                return starsLevel1_4;
            case 15:
                return starsLevel1_5;
            case 16:
                return starsLevel1_6;
            case 17:
                return starsLevel1_7;
            case 18:
                return starsLevel1_8;
            case 21:
                return starsLevel2_1;
            case 22:
                return starsLevel2_2;
            case 23:
                return starsLevel2_3;
            case 24:
                return starsLevel2_4;
            case 25:
                return starsLevel2_5;
            case 26:
                return starsLevel2_6;
            case 27:
                return starsLevel2_7;
            case 28:
                return starsLevel2_8;
            case 31:
                return starsLevel3_1;
            case 32:
                return starsLevel3_2;
            case 33:
                return starsLevel3_3;
            case 34:
                return starsLevel3_4;
            case 35:
                return starsLevel3_5;
            case 36:
                return starsLevel3_6;
            case 37:
                return starsLevel3_7;
            case 38:
                return starsLevel3_8;
        }
        return -1; //error
    }

    public void setLevelHighScore(int level, int value)
    {
        int currentScore;

        switch (level)
        {
            case 1:
                currentScore = starsLevel0_1;
                break;
            case 2:
                currentScore = starsLevel0_2;
                break;
            case 3:
                currentScore = starsLevel0_3;
                break;
            case 11:
                currentScore = starsLevel1_1;
                break;
            case 12:
                currentScore = starsLevel1_2;
                break;
            case 13:
                currentScore = starsLevel1_3;
                break;
            case 14:
                currentScore = starsLevel1_4;
                break;
            case 15:
                currentScore = starsLevel1_5;
                break;
            case 16:
                currentScore = starsLevel1_6;
                break;
            case 17:
                currentScore = starsLevel1_7;
                break;
            case 18:
                currentScore = starsLevel1_8;
                break;
            case 21:
                currentScore = starsLevel2_1;
                break;
            case 22:
                currentScore = starsLevel2_2;
                break;
            case 23:
                currentScore = starsLevel2_3;
                break;
            case 24:
                currentScore = starsLevel2_4;
                break;
            case 25:
                currentScore = starsLevel2_5;
                break;
            case 26:
                currentScore = starsLevel2_6;
                break;
            case 27:
                currentScore = starsLevel2_7;
                break;
            case 28:
                currentScore = starsLevel2_8;
                break;
            case 31:
                currentScore = starsLevel3_1;
                break;
            case 32:
                currentScore = starsLevel3_2;
                break;
            case 33:
                currentScore = starsLevel3_3;
                break;
            case 34:
                currentScore = starsLevel3_4;
                break;
            case 35:
                currentScore = starsLevel3_5;
                break;
            case 36:
                currentScore = starsLevel3_6;
                break;
            case 37:
                currentScore = starsLevel3_7;
                break;
            case 38:
                currentScore = starsLevel3_8;
                break;
            default:
                currentScore = -1; //error
                break;
        }

        if (value > currentScore && currentScore != -1)
        {
            switch (level)
            {
                case 1:
                    starsLevel0_1 = value;
                    SaveMan.GetComponent<SaveManager>().save.starsLevel0_1 = starsLevel0_1;
                    break;
                case 2:
                    starsLevel0_2 = value;
                    SaveMan.GetComponent<SaveManager>().save.starsLevel0_2 = starsLevel0_2;
                    break;
                case 3:
                    starsLevel0_3 = value;
                    SaveMan.GetComponent<SaveManager>().save.starsLevel0_3 = starsLevel0_3;
                    break;
                case 11:
                    starsLevel1_1 = value;
                    SaveMan.GetComponent<SaveManager>().save.starsLevel1_1 = starsLevel1_1;
                    break;
                case 12:
                    starsLevel1_2 = value;
                    SaveMan.GetComponent<SaveManager>().save.starsLevel1_2 = starsLevel1_2;
                    break;
                case 13:
                    starsLevel1_3 = value;
                    SaveMan.GetComponent<SaveManager>().save.starsLevel1_3 = starsLevel1_3;
                    break;
                case 14:
                    starsLevel1_4 = value;
                    SaveMan.GetComponent<SaveManager>().save.starsLevel1_4 = starsLevel1_4;
                    break;
                case 15:
                    starsLevel1_5 = value;
                    SaveMan.GetComponent<SaveManager>().save.starsLevel1_5 = starsLevel1_5;
                    break;
                case 16:
                    starsLevel1_6 = value;
                    SaveMan.GetComponent<SaveManager>().save.starsLevel1_6 = starsLevel1_6;
                    break;
                case 17:
                    starsLevel1_7 = value;
                    SaveMan.GetComponent<SaveManager>().save.starsLevel1_7 = starsLevel1_7;
                    break;
                case 18:
                    starsLevel1_8 = value;
                    SaveMan.GetComponent<SaveManager>().save.starsLevel1_8 = starsLevel1_8;
                    break;
                case 21:
                    starsLevel2_1 = value;
                    SaveMan.GetComponent<SaveManager>().save.starsLevel2_1 = starsLevel2_1;
                    break;
                case 22:
                    starsLevel2_2 = value;
                    SaveMan.GetComponent<SaveManager>().save.starsLevel2_2 = starsLevel2_2;
                    break;
                case 23:
                    starsLevel2_3 = value;
                    SaveMan.GetComponent<SaveManager>().save.starsLevel2_3 = starsLevel2_3;
                    break;
                case 24:
                    starsLevel2_4 = value;
                    SaveMan.GetComponent<SaveManager>().save.starsLevel2_4 = starsLevel2_4;
                    break;
                case 25:
                    starsLevel2_5 = value;
                    SaveMan.GetComponent<SaveManager>().save.starsLevel2_5 = starsLevel2_5;
                    break;
                case 26:
                    starsLevel2_6 = value;
                    SaveMan.GetComponent<SaveManager>().save.starsLevel2_6 = starsLevel2_6;
                    break;
                case 27:
                    starsLevel2_7 = value;
                    SaveMan.GetComponent<SaveManager>().save.starsLevel2_7 = starsLevel2_7;
                    break;
                case 28:
                    starsLevel2_8 = value;
                    SaveMan.GetComponent<SaveManager>().save.starsLevel2_8 = starsLevel2_8;
                    break;
                case 31:
                    starsLevel3_1 = value;
                    SaveMan.GetComponent<SaveManager>().save.starsLevel3_1 = starsLevel3_1;
                    break;
                case 32:
                    starsLevel3_2 = value;
                    SaveMan.GetComponent<SaveManager>().save.starsLevel3_2 = starsLevel3_2;
                    break;
                case 33:
                    starsLevel3_3 = value;
                    SaveMan.GetComponent<SaveManager>().save.starsLevel3_3 = starsLevel3_3;
                    break;
                case 34:
                    starsLevel3_4 = value;
                    SaveMan.GetComponent<SaveManager>().save.starsLevel3_4 = starsLevel3_4;
                    break;
                case 35:
                    starsLevel3_5 = value;
                    SaveMan.GetComponent<SaveManager>().save.starsLevel3_5 = starsLevel3_5;
                    break;
                case 36:
                    starsLevel3_6 = value;
                    SaveMan.GetComponent<SaveManager>().save.starsLevel3_6 = starsLevel3_6;
                    break;
                case 37:
                    starsLevel3_7 = value;
                    SaveMan.GetComponent<SaveManager>().save.starsLevel3_7 = starsLevel3_7;
                    break;
                case 38:
                    starsLevel3_8 = value;
                    SaveMan.GetComponent<SaveManager>().save.starsLevel3_8 = starsLevel3_8;
                    break;
            }
            SaveMan.GetComponent<SaveManager>().Save();
        }
    }

    void Load()
    {
        starsLevel0_1 = SaveMan.GetComponent<SaveManager>().save.starsLevel0_1;
        starsLevel0_2 = SaveMan.GetComponent<SaveManager>().save.starsLevel0_2;
        starsLevel0_3 = SaveMan.GetComponent<SaveManager>().save.starsLevel0_3;
        starsLevel1_1 = SaveMan.GetComponent<SaveManager>().save.starsLevel1_1;
        starsLevel1_2 = SaveMan.GetComponent<SaveManager>().save.starsLevel1_2;
        starsLevel1_3 = SaveMan.GetComponent<SaveManager>().save.starsLevel1_3;
        starsLevel1_4 = SaveMan.GetComponent<SaveManager>().save.starsLevel1_4;
        starsLevel1_5 = SaveMan.GetComponent<SaveManager>().save.starsLevel1_5;
        starsLevel1_6 = SaveMan.GetComponent<SaveManager>().save.starsLevel1_6;
        starsLevel1_7 = SaveMan.GetComponent<SaveManager>().save.starsLevel1_7;
        starsLevel1_8 = SaveMan.GetComponent<SaveManager>().save.starsLevel1_8;
        starsLevel2_1 = SaveMan.GetComponent<SaveManager>().save.starsLevel2_1;
        starsLevel2_2 = SaveMan.GetComponent<SaveManager>().save.starsLevel2_2;
        starsLevel2_3 = SaveMan.GetComponent<SaveManager>().save.starsLevel2_3;
        starsLevel2_4 = SaveMan.GetComponent<SaveManager>().save.starsLevel2_4;
        starsLevel2_5 = SaveMan.GetComponent<SaveManager>().save.starsLevel2_5;
        starsLevel2_6 = SaveMan.GetComponent<SaveManager>().save.starsLevel2_6;
        starsLevel2_7 = SaveMan.GetComponent<SaveManager>().save.starsLevel2_7;
        starsLevel2_8 = SaveMan.GetComponent<SaveManager>().save.starsLevel2_8;
        starsLevel3_1 = SaveMan.GetComponent<SaveManager>().save.starsLevel3_1;
        starsLevel3_2 = SaveMan.GetComponent<SaveManager>().save.starsLevel3_2;
        starsLevel3_3 = SaveMan.GetComponent<SaveManager>().save.starsLevel3_3;
        starsLevel3_4 = SaveMan.GetComponent<SaveManager>().save.starsLevel3_4;
        starsLevel3_5 = SaveMan.GetComponent<SaveManager>().save.starsLevel3_5;
        starsLevel3_6 = SaveMan.GetComponent<SaveManager>().save.starsLevel3_6;
        starsLevel3_7 = SaveMan.GetComponent<SaveManager>().save.starsLevel3_7;
        starsLevel3_8 = SaveMan.GetComponent<SaveManager>().save.starsLevel3_8;
    }

    public void CameraSwapJumpPrevention()
    {
        StartCoroutine(JumpDelayCamera());
    }

    IEnumerator JumpDelayCamera()
    {
        cameraSwap = true;
        yield return new WaitForSeconds(0.25f);
        cameraSwap = false;
    }
}