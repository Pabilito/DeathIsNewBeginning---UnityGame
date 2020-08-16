using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMinigame1 : MonoBehaviour
{
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
}
