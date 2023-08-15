using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UILoseGame : MonoBehaviour
{
    public TextMeshProUGUI textScore, bestScore, score1st, score2nd, score3rd;
    public GameObject table;
    public bool isTableOn = false;
    
    public void SetScore(int score)
    {
        textScore.text = "Your Score : " + score.ToString();
    }
    public void SetBestScore(int score)
    {   
        bestScore.text = "Best Score : " + score.ToString();
    }
    public void ReplayOnClick()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void QuitOnClick()
    {
        Application.Quit();
    }
    public void Show()
    {
        gameObject.SetActive(true);
    }
    public void ShowTable()
    {
         if(isTableOn == false){
            table.SetActive(true);
            isTableOn = true;
        }else{
            table.SetActive(false);
            isTableOn = false;
        }

    }
    public void SetTable(int score1st, int score2nd, int score3rd)
    {   
        this.score1st.text =  "1ST :  " + score1st.ToString();
        this.score2nd.text =  "2ND :  " + score2nd.ToString();
        this.score3rd.text =  "3RD :  " + score3rd.ToString();
    }
}
