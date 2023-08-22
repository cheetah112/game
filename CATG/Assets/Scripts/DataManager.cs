using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    private int currentScore;
    public static DataManager Instance = null;
    private void Awake() {
        Instance = this;
        if (!PlayerPrefs.HasKey("FirstPlay"))
        {
            currentScore = 0;
            PlayerPrefs.SetInt("FirstPlay", 0);
            PlayerPrefs.SetInt("1st", 0);
            PlayerPrefs.SetInt("2nd", 0);
            PlayerPrefs.SetInt("3rd", 0);

        }
    }
    public int GetCurrentScore()
    {
        return currentScore;
    }
    public void AddScore()
    {
        currentScore++;
    }
    public void UpdateTable(){
        int top1 = PlayerPrefs.GetInt("1st");
        int top2 = PlayerPrefs.GetInt("2nd");
        int top3 = PlayerPrefs.GetInt("3rd");
        if(currentScore != top1 && currentScore != top2 && currentScore !=top3){
            if(currentScore > top1 ){
                PlayerPrefs.SetInt("3rd", top2);
                PlayerPrefs.SetInt("2nd", top1);
                PlayerPrefs.SetInt("1st", currentScore);
            }
            else if(currentScore > top2){
                PlayerPrefs.SetInt("3rd", top2);
                PlayerPrefs.SetInt("2nd", currentScore);
            }else if(currentScore > top3){
                PlayerPrefs.SetInt("3rd", currentScore);
            }
        }
    }
}
