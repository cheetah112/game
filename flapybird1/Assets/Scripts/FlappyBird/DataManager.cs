using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;
    public int Score = 0;
    private void Awake(){
        Instance = this;
        if(!PlayerPrefs.HasKey("FirstPlay")){
            Score = 0;
            PlayerPrefs.SetInt("FirstPlay", 0);
            PlayerPrefs.SetInt("1st", 0);
            PlayerPrefs.SetInt("2nd", 0);
            PlayerPrefs.SetInt("3rd", 0);
        }
    }
    public void addScore()
    {
        Score++;
    }
    public int GetScore()
    {
        return Score;
    }

    public void UpdateBoard(int CurrentScore){
        int top1 = PlayerPrefs.GetInt("1st");
        int top2 = PlayerPrefs.GetInt("2nd");
        int top3 = PlayerPrefs.GetInt("3rd");
        if(CurrentScore != top1 && CurrentScore != top2 && CurrentScore !=top3){
            if(CurrentScore > top1 ){
                PlayerPrefs.SetInt("3rd", top2);
                PlayerPrefs.SetInt("2nd", top1);
                PlayerPrefs.SetInt("1st", CurrentScore);
            }
            else if(CurrentScore > top2){
                PlayerPrefs.SetInt("3rd", top2);
                PlayerPrefs.SetInt("2nd", CurrentScore);
            }else if(CurrentScore > top3){
                PlayerPrefs.SetInt("3rd", CurrentScore);
            }
        }
    }
}
