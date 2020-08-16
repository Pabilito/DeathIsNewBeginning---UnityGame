using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinHandler0_2 : MonoBehaviour
{
    public GameObject player;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player") && player.GetComponent<HealthAndPointsManager>().getPoints() > 0)
        {
            GlobalVariables.instance.setLevelHighScore(2, 1);
        }
    }
}
