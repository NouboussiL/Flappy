using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateScore : MonoBehaviour
{
    public Text scoreText;
    public Text highscore;
    // Start is called before the first frame update
    void Start()
    {
        if (gameManager.Instance != null)
        {
            scoreText.text = gameManager.Instance.score.ToString();
            if (highscore != null) highscore.text += gameManager.Instance.highscore.ToString();
        }
    }


    // Update is called once per frame
    void Update()
    {
        if(gameManager.Instance!=null)scoreText.text = gameManager.Instance.score.ToString();
    }
}
