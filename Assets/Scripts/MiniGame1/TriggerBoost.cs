using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBoost : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        col.GetComponent<Rigidbody2D>().velocity = Vector2.up * 50.0f * Mathf.Cos(this.transform.eulerAngles.z * Mathf.PI / 180) + Vector2.left * 50.0f * Mathf.Sin(this.transform.eulerAngles.z * Mathf.PI / 180);
    }
}
