using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HUDHandler : MonoBehaviour
{
    public Text winTxt;
    public Text defeatTxt;
    public Text lastLifeWarning;
    public Button pauseButton;
    public Button nextLevel;
    public bool paused = false;
    public GameObject player;
    public Button BackToMenu;
    public Button Retry;
    public Image bigStar1;
    public Image bigStar2;
    public Image bigStar3;
    bool gameEnded = false;

    private Color visible = new Vector4(1.0f, 1.0f, 1.0f, 1.0f);
    private Color invisible = new Vector4(0.3f, 0.4f, 0.6f, 0.3f);

    void Start()
    {
        defeatTxt.enabled = false;
        winTxt.enabled = false;
        lastLifeWarning.enabled = false;
        showMenuButtons(false);
        nextLevel.gameObject.SetActive(false);
        showBigPoints(0, false);
    }

    public void showWinTxt()
    {
        nextLevel.gameObject.SetActive(true);
        showMenuButtons(true);
        winTxt.enabled = true;
        showBigPoints(player.GetComponent<HealthAndPointsManager>().getPoints(), true);
        player.GetComponent<HealthAndPointsManager>().hidePoints();
        pauseButton.gameObject.SetActive(false);
    }

    public void onDeath()
    {
        player.GetComponent<PlayerMovement>().endGame();
        defeatTxt.enabled = true;
        Destroy(lastLifeWarning.gameObject);
        showMenuButtons(true);
        pauseButton.gameObject.SetActive(false);
        showBigPoints(0, true);
    }

    public void showLastLifeWarning(bool visible)
    {
        lastLifeWarning.enabled = visible;
    }

    public void onPause()
    {
        paused = !paused;
        if (paused)
        {
            player.GetComponent<Rigidbody2D>().simulated = false;
            showMenuButtons(true);
        }
        else
        {
            player.GetComponent<Rigidbody2D>().simulated = true;
            showMenuButtons(false);
        }

    }

    void showBigPoints(int number, bool show)
    {
        if (show)
        {
            bigStar1.enabled = true;
            bigStar2.enabled = true;
            bigStar3.enabled = true;

            switch (number)
            {
                case 0:
                    bigStar1.color = invisible;
                    bigStar2.color = invisible;
                    bigStar3.color = invisible;
                    break;
                case 1:
                    bigStar1.color = visible;
                    bigStar2.color = invisible;
                    bigStar3.color = invisible;
                    break;
                case 2:
                    bigStar1.color = visible;
                    bigStar2.color = visible;
                    bigStar3.color = invisible;
                    break;
                case 3:
                    bigStar1.color = visible;
                    bigStar2.color = visible;
                    bigStar3.color = visible;
                    break;
            }
        }
        else
        {
            bigStar1.enabled = false;
            bigStar2.enabled = false;
            bigStar3.enabled = false;
        }
    
    }

    void showMenuButtons(bool show)
    {
        BackToMenu.gameObject.SetActive(show);
        Retry.gameObject.SetActive(show);
    }

    public void onRetry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void onMenu()
    {
        SceneManager.LoadScene("GameScene#1");
    }

    public void onMenu1()
    {
        SceneManager.LoadScene("Selection1");
    }
}
