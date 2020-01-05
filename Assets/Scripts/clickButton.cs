using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clickButton : MonoBehaviour
{

    public void onClick()
    {
        SceneManager.LoadScene("scene3-Game");
    }
}
