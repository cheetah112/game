using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    
    public GameObject buttonStartGame;
    public Button buttonPauseGame;
    public Button buttonReplay;
    public Button buttonBroadScore;
    public TextMeshProUGUI textScore;
    public TextMeshProUGUI scoreInBoard;
    public TextMeshProUGUI bestScore;
    public TextMeshProUGUI top1;
    public TextMeshProUGUI top2;
    public TextMeshProUGUI top3;

    public Image MedalImage;
    public GameObject SplashScreen;
    public Sprite MedalGold;
    public Sprite MedalSilver;
    public Sprite MedalBrone;
    public Sprite PauseImage;
    public Sprite ResumeImage;
    public GameObject LoseGamePanel;
    public GameObject BoardPanel;
    public bool BoardOn;
    void Start()
    {
        Instance = this;
        LoseGamePanel.SetActive(false);
        textScore.gameObject.SetActive(false);
        BoardOn = false;
        BoardPanel.SetActive(false);
    }

    public void StartGameOnClick(){
        GameManager.Instance.StartGame();
        buttonStartGame.SetActive(false);
        textScore.gameObject.SetActive(true);
    }
    public void PauseGameOnClick(){
        GameManager.Instance.PauseGame();
        if(GameManager.Instance.isPauseGame == false){
            buttonPauseGame.image.sprite = PauseImage;
        }
        else{
            buttonPauseGame.image.sprite = ResumeImage;
        }
    }
    public void UpdateScore(int Score)
    {
        textScore.text = Score.ToString();
    }
    public void GameOver(){
        StartCoroutine(LoseGame());
    }

    public void SetMedal(int score){
        if(score > 5) MedalImage.sprite = MedalGold;
        else if(score > 3) MedalImage.sprite = MedalSilver;
        else MedalImage.sprite = MedalBrone;
    }

    public void ScoreInLoseGamePanel(int Score){        
        StartCoroutine(CountingScore(Score,1.5f));
    }

    private IEnumerator LoseGame(){
        SplashScreen.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        SplashScreen.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        LoseGamePanel.SetActive(true);
        textScore.gameObject.SetActive(false);
    }

    private IEnumerator CountingScore(int Score, float duration)
    {
        scoreInBoard.text = 0.ToString();
        yield return new WaitForSeconds(2f);
        if(Score > 0){
            float yieldTime = duration/Score;
            for(int i = 0 ; i <= Score; i++)
            {
                scoreInBoard.text = i.ToString();
                yield return new WaitForSeconds(yieldTime);
            }
        }
        buttonBroadScore.gameObject.SetActive(true);
        buttonReplay.gameObject.SetActive(true);
    }

    public void ReloadGame()
    {
        SceneManager.LoadScene(0);
    }

    public void BoardOnByClick(){
        if(BoardOn == false){
            BoardPanel.SetActive(true);
            BoardOn = true;
        }else{
            BoardPanel.SetActive(false);
            BoardOn = false;
        }
    }
    public void setBoardScore(){
        int t1 = PlayerPrefs.GetInt("1st");
        int t2 = PlayerPrefs.GetInt("2nd");
        int t3 = PlayerPrefs.GetInt("3rd");
        bestScore.text = t1.ToString();
        top1.text = "Top 1:  " + t1.ToString() ;
        top2.text = "Top 2:  " + t2.ToString();
        top3.text = "Top 3:  " + t3.ToString();
    }
}
