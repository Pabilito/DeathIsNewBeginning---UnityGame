using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomizer1_8 : MonoBehaviour
{
    public GameObject point;
    public GameObject obstacle;

    void Start()
    {
        int x = Random.Range(0, 2);
        if (x == 0)
        {
            Vector2 position;
            position = point.transform.position;
            point.transform.position = obstacle.transform.position;
            obstacle.transform.position = position;
        }
    }

}
