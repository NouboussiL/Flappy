﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wait2Sec : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("goScene2", 2.0f);
    }

   void goScene2()
    {
        SceneManager.LoadScene("scene2-Menu");
    }
}
