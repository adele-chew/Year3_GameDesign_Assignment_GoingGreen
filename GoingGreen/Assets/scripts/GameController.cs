using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{
    /// <summary>
    /// game controller to control game behavior and management
    /// </summary>
    public static GameController instance;
    public TMP_Text scoreText;
    public bool levelEnd = false;

    public GameObject EndLevel;
    public TMP_Text endScore;
    public TMP_Text highestScore;


    private int score = 0; 

    // Start is called before the first frame update
    public void Start()
    {
        if (instance == null)
        {
            instance = this; 
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        highestScore.text = PlayerPrefs.GetInt("HighestScore", 0).ToString();
    }

    // Update is called once per frame
    public void Update()
    {
        //originally used for prototype
        /*if(Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("Quit");
            Application.Quit();
        }*/
    }

    public void GameScore()
    {
        if(levelEnd)
        {
            return;
        }
        score++;
        scoreText.text = "Score: " + score.ToString();
    }

    public void GameDeduct()
    {
        if (levelEnd)
        {
            return;
        }
        score--;
        scoreText.text = "Score: " + score.ToString();
    }

    public void LevelEnd()
    {
        Time.timeScale = 0f;
        levelEnd = true;
        EndLevel.SetActive(true);

        endScore.text = score.ToString();
        if (score > PlayerPrefs.GetInt("HighestScore", 0))
        {
            PlayerPrefs.SetInt("HighestScore", score);
            highestScore.text = score.ToString();
        }
    }
}
