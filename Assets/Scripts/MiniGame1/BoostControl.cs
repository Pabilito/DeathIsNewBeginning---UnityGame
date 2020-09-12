using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostControl : MonoBehaviour
{
    bool activated = false;
    public GameObject boost;
    public bool isRight = true;

    void Update()
    {
        if (activated)
        {
            if (isRight)
            {
                boost.transform.Rotate(0, 0, -1.4f);
            }
            else
            {
                boost.transform.Rotate(0, 0, 1.4f);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        activated = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        activated = false;
    }
}
