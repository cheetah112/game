using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButtonPause : MonoBehaviour
{
    public Image imageButton;
    public Sprite pauseImage;
    public Sprite resumeImmage;

    public void PauseGameOnClick()
    {
        GameManager.Instance.PauseGame();
        ChangeButton();
    }
    private void ChangeButton()
    {
        if (GameManager.Instance.isPauseGame)
        {
            imageButton.sprite = resumeImmage;
        }
        else
        {
            imageButton.sprite = pauseImage;
        }
    }
}
