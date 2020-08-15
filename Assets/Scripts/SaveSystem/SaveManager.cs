using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public static SaveManager instance { set; get; }
    public Save save;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject); //can be accessed anywhere
        instance = this;
        Load();
    }

    public void Save()
    {
        //print("Saved");
        PlayerPrefs.SetString("save", SaveLoadHelper.Serialize<Save>(save));
    }

    public void Load()
    {
        if (PlayerPrefs.HasKey("save"))
        {
            save = SaveLoadHelper.Deserialize<Save>(PlayerPrefs.GetString("save"));
           //print("Loaded");
        }
        else
        {
            save = new Save();
            Save();
            //print("New save created");
        }
    }

}
