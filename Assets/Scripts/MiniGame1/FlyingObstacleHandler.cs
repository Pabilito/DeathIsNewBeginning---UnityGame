using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingObstacleHandler : MonoBehaviour
{
    private Rigidbody2D rb2D;
    public float speedLeft = 1.0f;

    void Start()
    {
        rb2D = transform.GetComponent<Rigidbody2D>();
        rb2D.velocity = Vector2.left * speedLeft;
    }

    private void Update() //not the most efficient option
    {
        if (GameObject.FindGameObjectWithTag("EventSystem").GetComponent<HUDHandler>().paused)
        {
            this.GetComponent<Rigidbody2D>().simulated = false;
        }
        else
        {
            this.GetComponent<Rigidbody2D>().simulated = true;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(this.gameObject);
    }
}