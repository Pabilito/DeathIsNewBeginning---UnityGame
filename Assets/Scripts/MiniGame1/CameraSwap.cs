using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwap : MonoBehaviour
{
    public Camera main;
    public Camera secondary;

    // Start is called before the first frame update
    void Start()
    {
        main.enabled = true;
        secondary.enabled = false;
    }

    public void SwapCamera()
    {
        secondary.enabled = main.enabled;
        main.enabled = !main.enabled;
        GlobalVariables.instance.CameraSwapJumpPrevention();
    }
}
