using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class ArrowScript : MonoBehaviour
{
    public GameObject player;
    public GameObject finish;
    Vector3 positionPlayer;
    Vector2 positionFinish;

    private void Start()
    {
        positionFinish = finish.transform.position;
    }

    void Update()
    {
        positionPlayer = player.transform.position;
        double deltax = positionFinish.x - positionPlayer.x;
        double deltay = positionFinish.y - positionPlayer.y;
        double rotationZWithoutOffset = Math.Atan(deltay / deltax);
        double rotationz = (rotationZWithoutOffset - Math.PI) * 180 / Math.PI;
        print(rotationz);
        this.transform.rotation = Quaternion.AngleAxis(Convert.ToSingle(rotationz), Vector3.forward);
        this.transform.position = new Vector3(positionPlayer.x + 2 * Convert.ToSingle(Math.Cos(rotationZWithoutOffset)),
            positionPlayer.y + 2 * Convert.ToSingle(Math.Sin(rotationZWithoutOffset)), -9); 
    }
}
