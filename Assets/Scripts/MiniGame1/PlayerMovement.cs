﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 5.0f;
    private Rigidbody2D rb2D;
    private float thrust = 10.0f;
    public bool airborne = false;
    private Vector2 spawn;
    public GameObject deadBody;
    public GameObject levelManager;
    private bool gameEnded;
    public AudioSource hitSound;
    public AudioSource heartSound;
    public AudioSource pointSound;
    public AudioSource finishSound;
    private bool deathDelay = false;

    void Start()
    {
        spawn = this.GetComponent<Transform>().transform.position;
        rb2D = transform.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!gameEnded && !levelManager.GetComponent<HUDHandler>().paused)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0) && !airborne && !levelManager.GetComponent<HUDHandler>().paused)
            {
                StartCoroutine(JumpDelay());
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                rb2D.velocity = rb2D.velocity + Vector2.left * speed;
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                rb2D.velocity = rb2D.velocity + Vector2.right * speed;
            }

            Vector3 dir = Vector3.zero;

            dir.x = Input.acceleration.x;

            // clamp acceleration vector to unit sphere
            if (dir.sqrMagnitude > 1)
                dir.Normalize();

            // Make it move 10 meters per second instead of 10 meters per frame...
            dir *= Time.deltaTime;

            // Move object
            transform.Translate(dir * 2 * speed);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Wood") || col.gameObject.CompareTag("DeadBody"))
        {
            airborne = false;
        }
        else if (col.gameObject.CompareTag("PortalIn"))
        {
            teleport();
        }
        else if (col.gameObject.CompareTag("Obstacle"))
        {
            respawn();
        }
        else if (col.gameObject.CompareTag("Life"))
        {
            Destroy(col.gameObject);
            if (GlobalVariables.musinOn)
            {
                heartSound.Play();
            }
            this.gameObject.GetComponent<HealthAndPointsManager>().addLife();
        }
        else if (col.gameObject.CompareTag("Point"))
        {
            Destroy(col.gameObject);
            if (GlobalVariables.musinOn)
            {
                pointSound.Play();
            }
            this.gameObject.GetComponent<HealthAndPointsManager>().addPoint();
        }
        else if (col.gameObject.CompareTag("Meta") && this.GetComponent<HealthAndPointsManager>().getPoints() > 0)
        {
            gameEnded = true;
            levelManager.GetComponent<HUDHandler>().showLastLifeWarning(false);
            levelManager.GetComponent<HUDHandler>().showWinTxt();
            this.gameObject.GetComponent<Rigidbody2D>().simulated = false;
            if (GlobalVariables.musinOn)
            {
                finishSound.Play();
            }    
        }
        else if (col.gameObject.CompareTag("Meta"))
        {
            airborne = false; //jump reset
        }
        else if (col.gameObject.CompareTag("FlyingObstacle"))
        {
            respawn();
            Destroy(col.gameObject);
        }
    }

    IEnumerator JumpDelay()
    {
        yield return new WaitForSeconds(0.1f);
        if (!levelManager.GetComponent<HUDHandler>().paused && !GlobalVariables.instance.cameraSwap) {
            airborne = true;
            rb2D.velocity = Vector2.up * thrust;
        }
    }

    IEnumerator DeathDelay() //prevents multiple deaths
    {
        deathDelay = true;
        yield return new WaitForSeconds(0.1f);
        deathDelay = false;
    }

    void teleport()
    {
        Vector3 spawnpos = GameObject.FindGameObjectWithTag("PortalOut").transform.position;
        this.transform.position = spawnpos;
    }

    void respawn()
    {
        if (!deathDelay)
        {
            StartCoroutine(DeathDelay());
            Vector3 spawnpos = this.GetComponent<Transform>().transform.position;
            this.gameObject.GetComponent<HealthAndPointsManager>().removeLife();
            if (this.gameObject.GetComponent<HealthAndPointsManager>().getHealth() != -1) //don't move camera on last death
            {
                this.transform.position = spawn;
            }
            Instantiate(deadBody, spawnpos, transform.rotation);
            this.rb2D.velocity = Vector2.zero;
            if (GlobalVariables.musinOn)
            {
                hitSound.Play();
            }
        }
    }

    public void endGame()
    {
        gameEnded = true;
        Color color = Color.white;
        color.a = 0.0f;
        this.gameObject.GetComponent<SpriteRenderer>().color = color;
        this.gameObject.GetComponent<Rigidbody2D>().simulated = false;
    }

}
