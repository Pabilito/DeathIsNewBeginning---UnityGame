using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinHandler1_2 : MonoBehaviour
{
    public GameObject player;
    void OnCollisionEnter2D(Collision2D col)
    {
        int points = player.GetComponent<HealthAndPointsManager>().getPoints();

        switch (SceneManager.GetActiveScene().name)
        {
            case "Level1_2":
                if (points > 0)
                {
                    GlobalVariables.instance.setLevelHighScore(12, points);
                }
                break;
            case "Level1_3":
                if (points > 0)
                {
                    GlobalVariables.instance.setLevelHighScore(13, points);
                }
                break;
            case "Level1_4":
                if (points > 0)
                {
                    GlobalVariables.instance.setLevelHighScore(14, points);
                }
                break;
            case "Level1_5":
                if (points > 0)
                {
                    GlobalVariables.instance.setLevelHighScore(15, points);
                }
                break;
            case "Level1_6":
                if (points > 0)
                {
                    GlobalVariables.instance.setLevelHighScore(16, points);
                }
                break;
            case "Level1_7":
                if (points > 0)
                {
                    GlobalVariables.instance.setLevelHighScore(17, points);
                }
                break;
            case "Level1_8":
                if (points > 0)
                {
                    GlobalVariables.instance.setLevelHighScore(18, points);
                }
                break;
        }
    }
}
