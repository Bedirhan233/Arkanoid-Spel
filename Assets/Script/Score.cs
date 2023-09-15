using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI FinalScore;
    public GameObject background;
    public GameObject mainText;
    public GameObject restartButton;

    int currentScore;
    // Start is called before the first frame update
    void Start()
    {
        FinalScore.enabled = false;
        background.SetActive(false);  
        mainText.SetActive(false);
        restartButton.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void GameOver()
    {
        Time.timeScale = 0;
        FinalScore.enabled = true;
        background.SetActive(true);
        mainText.SetActive(true);
        restartButton.SetActive(true);
        scoreText.enabled = false;
    }


    public  void Restart()
    {
        Time.timeScale = 1;
        FinalScore.enabled = false;
        background.SetActive(false);
        mainText.SetActive(false);
        restartButton.SetActive(false);
        scoreText.enabled = false;
        string currentScene = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentScene);
        
    }

    public int winpoints(int inkomst)
    {
        currentScore = currentScore + inkomst;


        scoreText.text = currentScore.ToString();
        FinalScore.text = "Your score is " + currentScore.ToString();
        return currentScore;
        
    }
}
