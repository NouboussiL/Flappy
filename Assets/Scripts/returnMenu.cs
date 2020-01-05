using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class returnMenu : MonoBehaviour
{
    void Update()
    {
        if (Input.touchCount > 0 || Input.GetKeyDown("space"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("scene2-Menu");
            gameManager.Instance.resetScore();
        }
    }
}
