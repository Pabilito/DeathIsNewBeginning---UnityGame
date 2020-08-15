using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GlobalVariables : MonoBehaviour
{
    public GameObject SaveMan;
    static int starsLevel1 = 0;
    static int starsLevel2 = 0;

    void Start()
    {
        Load();
    }

    public int getLevelScore(int level)
    {
        switch (level)
        {
            case 1:
                return starsLevel1;
            case 2:
                return starsLevel2;
        }
        return -1; //error
    }

    void setLevelHighScore(int level, int value)
    {
        int currentScore;

        switch (level)
        {
            case 1:
                currentScore = starsLevel1;
                break;
            case 2:
                currentScore = starsLevel2;
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
                    currentScore = starsLevel1;
                    SaveMan.GetComponent<SaveManager>().save.starsLevel1 = starsLevel1;
                    break;
                case 2:
                    currentScore = starsLevel2;
                    SaveMan.GetComponent<SaveManager>().save.starsLevel2 = starsLevel2;
                    break;
            }
            SaveMan.GetComponent<SaveManager>().Save();
        }
    }

    void Load()
    {
        starsLevel1 = SaveMan.GetComponent<SaveManager>().save.starsLevel1;
        starsLevel2 = SaveMan.GetComponent<SaveManager>().save.starsLevel2;
    }
}