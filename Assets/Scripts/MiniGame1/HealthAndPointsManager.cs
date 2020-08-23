using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthAndPointsManager : MonoBehaviour
{
    private int health = 2;
    private int points = 0;
    public GameObject levelManager;

    public Image lives1;
    public Image lives2;
    public Image lives3;
    public Image points1;
    public Image points2;
    public Image points3;

    private Color visible = new Vector4(1.0f, 1.0f, 1.0f, 1.0f);
    private Color invisible = new Vector4(0.3f, 0.4f, 0.6f, 0.3f);
    private Color superInvisible = new Vector4(0.3f, 0.4f, 0.6f, 0.0f);

    private void Start()
    {
        if (GlobalVariables.instance.extraLifeOn)
        {
            health = 3;
            GlobalVariables.instance.extraLifeOn = false;
        }
        adjustLivesHUD();
        adjustPointsHUD();
    }

    public int getPoints()
    {
        return points;
    }

    public int getHealth()
    {
        return health;
    }

    public void removeLife()
    {
        //print(health);
        if (health > 0)
        {
            health--;
            adjustLivesHUD();
        }
        else
        {
            health--;
            hidePoints();
            levelManager.GetComponent<HUDHandler>().onDeath();
        }
    }

    public void addPoint()
    {
        points++;
        adjustPointsHUD();
    }

    public void addLife()
    {
        if (health < 3)
        {
            health++;
            adjustLivesHUD();
        }
    }

    void adjustLivesHUD()
    {
        switch (health)
        {
            case 0:
                levelManager.GetComponent<HUDHandler>().showLastLifeWarning(true);
                lives1.enabled = false;
                lives2.enabled = false;
                lives3.enabled = false;
                break;
            case 1:
                levelManager.GetComponent<HUDHandler>().showLastLifeWarning(false);
                lives1.enabled = true;
                lives2.enabled = false;
                lives3.enabled = false;
                break;
            case 2:
                lives1.enabled = true;
                lives2.enabled = true;
                lives3.enabled = false;
                break;
            case 3:
                lives1.enabled = true;
                lives2.enabled = true;
                lives3.enabled = true;
                break;
        }
    }

    void adjustPointsHUD()
    {
        switch (points)
        {
            case 0:
                points1.color = invisible;
                points2.color = invisible;
                points3.color = invisible;
                break;
            case 1:
                points1.color = visible;
                points2.color = invisible;
                points3.color = invisible;
                break;
            case 2:
                points1.color = visible;
                points2.color = visible;
                points3.color = invisible;
                break;
            case 3:
                points1.color = visible;
                points2.color = visible;
                points3.color = visible;
                break;
        }
    }

    public void hidePoints()
    {
        points1.color = superInvisible;
        points2.color = superInvisible;
        points3.color = superInvisible;
    }
}
