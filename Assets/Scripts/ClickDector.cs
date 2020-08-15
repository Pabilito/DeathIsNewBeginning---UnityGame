using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDector : MonoBehaviour
{
    private void Update()
    {
        //detects if "player" was clicked ot sth else
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Input.mousePosition;
            Collider2D hitCollider = Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(pos));
            if (hitCollider != null && hitCollider.CompareTag("Player"))
            {
                Debug.Log("This is player");
            }
            else
            {
                print("NO");
            }
        }
    }
}
