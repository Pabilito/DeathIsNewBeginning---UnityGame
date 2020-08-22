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
    }

    public int getLevelSum(int levels)
    {
        switch (levels)
        {
            case 1:
                calculateSums();
                return sumLevels1;
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

    }
}