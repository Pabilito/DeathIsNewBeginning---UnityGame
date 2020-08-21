using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{
    private void Start()
    {
        if(SceneManager.GetActiveScene().name == "BufforScene")
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    public void OnLevel0_1()
    {
        SceneManager.LoadScene("Level0_1");
    }

    public void OnLevel0_2()
    {
        SceneManager.LoadScene("Level0_2");
    }

    public void OnLevel0_3()
    {
        SceneManager.LoadScene("Level0_3");
    }

    public void OnLevels1()
    {
        SceneManager.LoadScene("Selection1");
    }
}
