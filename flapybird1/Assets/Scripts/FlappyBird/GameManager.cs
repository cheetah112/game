using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;
    public bool isEndGame;
    public bool isStartGame;
    public bool isPauseGame;
    private int collisionCount = 0;
    public Bird bird;

    private void Start()
    {
        Instance = this;
        isStartGame = false;
        isPauseGame = false;
        
    } 
    public void EndGame()
    {
        if(collisionCount == 0)
        {
            isEndGame = true;
            int Score = DataManager.Instance.GetScore();
            DataManager.Instance.UpdateBoard(Score);
            AudioManager.Instance.PlayDie();
            UIManager.Instance.setBoardScore();
            UIManager.Instance.GameOver();
            UIManager.Instance.SetMedal(Score);
            UIManager.Instance.ScoreInLoseGamePanel(Score);
        }
        collisionCount++;
    }

    public void StartGame()
    {
        isStartGame = true;
        bird.StartGame();
        
    }

    public void PauseGame()
    {
        if(isPauseGame == false)
        {
            Pause();
        }
        else
        {
            Remuse();
        }
    }
    public void Pause()
    {
        isPauseGame = true;
        Time.timeScale = 0;
        AudioManager.Instance.gameObject.SetActive(false);
    }

    public void Remuse()
    {
        isPauseGame = false;
        Time.timeScale = 1;
        AudioManager.Instance.gameObject.SetActive(true);
    }
    public void addScore()
    {
        if(isEndGame) return;
        DataManager.Instance.addScore();
        int Score = DataManager.Instance.GetScore();
        UIManager.Instance.UpdateScore(Score);
        AudioManager.Instance.PlayPoint();
    }
}
