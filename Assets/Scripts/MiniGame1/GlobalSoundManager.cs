using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalSoundManager : MonoBehaviour
{
    public static GlobalSoundManager instance { set; get; }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject); //can be accessed anywhere
        instance = this;
    }

}
