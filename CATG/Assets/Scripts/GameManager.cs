using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public Transform catFirstPos;
    public bool reload = true;
    public bool isStartGame = false;
    public bool isEndGame = false;
    public bool isPauseGame = false;
    private void Start() {
        Instance = this;
    }
    public void AddScore(){
        DataManager.Instance.AddScore();
        UIManager.Instance.UpdateScore();
    }
    public void EndGame()
    {
        DataManager.Instance.UpdateTable();
        isEndGame = true;
        UIManager.Instance.LoseGame();
    }
    public void StartGame()
    {
        isStartGame = true;
    }
    public void Reload()
    {
        reload = true;
    }
    public void PauseGame()
    {
        if(isPauseGame == false){
            Time.timeScale = 0;
            isPauseGame = true;
        }else
        {
            Time.timeScale = 1;
            isPauseGame = false;
        }
    }
    public int GetScore(){
        return DataManager.Instance.GetCurrentScore();
    }

}
