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

    private void Awake()
    {
        DontDestroyOnLoad(gameObject); //can be accessed anywhere
        instance = this;
    }

    void Start()
    {
        Load();
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
            default:
                currentScore = -1; //error
                break;
        }

        if (value > currentScore && currentScore != -1)
        {
            switch (level)
            {
                case 1:
                    currentScore = starsLevel0_1;
                    SaveMan.GetComponent<SaveManager>().save.starsLevel0_1 = starsLevel0_1;
                    break;
                case 2:
                    currentScore = starsLevel0_2;
                    SaveMan.GetComponent<SaveManager>().save.starsLevel0_2 = starsLevel0_2;
                    break;
                case 3:
                    currentScore = starsLevel0_3;
                    SaveMan.GetComponent<SaveManager>().save.starsLevel0_3 = starsLevel0_3;
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
    }
}