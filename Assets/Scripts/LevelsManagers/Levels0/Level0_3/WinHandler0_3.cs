using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinHandler0_3 : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<HealthAndPointsManager>().getPoints() > 0)
        {
            GlobalVariables.instance.setLevelHighScore(3, 1);
        }
    }
}
