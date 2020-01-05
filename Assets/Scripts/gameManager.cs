using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public static gameManager Instance { get; private set; }

    public GameObject bird;
    public int score;
    public int highscore;
    public bool alreadyDead;

    private void Awake()
    {
        if (Instance == null) { 
            Instance = this;
            DontDestroyOnLoad(gameObject);
            highscore = PlayerPrefs.GetInt("highScore", 0);
        }
        else
        {
            Destroy(gameObject);
            highscore = PlayerPrefs.GetInt("highScore", 0);
        }

    }


    public void dead()
    {
        alreadyDead = true;
    }

    public void resetScore()
    {
        score = 0;
        alreadyDead = false;
    }


    public void addScore()
    {
        if (!alreadyDead)
        {
            score++;
            if (score > highscore)
            {
                highscore = score;
                PlayerPrefs.SetInt("highScore", highscore);
            }
        }
        //scoreTxt.text = alreadyDead && score<100? "0"+score.ToString(): score.ToString();
    }




}
