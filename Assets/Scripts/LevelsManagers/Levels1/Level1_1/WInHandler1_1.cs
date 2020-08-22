using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WInHandler1_1 : MonoBehaviour
{
    public GameObject player;
    void OnCollisionEnter2D(Collision2D col)
    {
        int points = player.GetComponent<HealthAndPointsManager>().getPoints();
        if (points > 0)
        {
            GlobalVariables.instance.setLevelHighScore(11, points);
        }
    }
}
