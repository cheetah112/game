using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance = null;
    public GameObject buttonStartGame;
    public TextMeshProUGUI textScore;
    public UILoseGame losePanel;
    public GameObject endGameImage;
    private void Start() {
        Instance = this;
    }
    public void PlayGameOnClick()
    {
        GameManager.Instance.StartGame();
        buttonStartGame.SetActive(false);
    }
    public void UpdateScore()
    {
        int score = GameManager.Instance.GetScore();
        textScore.text = score.ToString();
    }
    public void LoseGame()
    {
        int score = GameManager.Instance.GetScore();
        losePanel.SetScore(score);
        int bestScore = PlayerPrefs.GetInt("1st");
        int score2nd = PlayerPrefs.GetInt("2nd");
        int score3rd = PlayerPrefs.GetInt("3rd");
        losePanel.SetBestScore(bestScore);
        losePanel.SetTable(bestScore, score2nd, score3rd);
        StartCoroutine(End());
    }
    IEnumerator End()
    {
        endGameImage.SetActive(true);
        yield return new WaitForSeconds(3f);
        endGameImage.SetActive(false);
        losePanel.Show();
    }    
}
