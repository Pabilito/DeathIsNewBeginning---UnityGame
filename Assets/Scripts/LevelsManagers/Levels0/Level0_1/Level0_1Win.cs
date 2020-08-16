using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level0_1Win : MonoBehaviour
{
    public GameObject player;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player") && player.GetComponent<HealthAndPointsManager>().getPoints() > 0)
        {
            GlobalVariables.instance.setLevelHighScore(1, 1);
        }
    }
}
