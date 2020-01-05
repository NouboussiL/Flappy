using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchAction : MonoBehaviour
{
    private GameObject bird;
    private moveBird scriptBird;

    private void Start()
    {
        bird = GameObject.FindGameObjectWithTag("Bird");
        scriptBird = (moveBird)bird.GetComponent(typeof(moveBird));
        gameManager.Instance.bird = bird;
    }


    void Update()
    {
        if (Input.touchCount > 0)
        {
            scriptBird.kick();
            GetComponent<AudioSource>().Play();
        }
        if (Input.GetKeyDown("space"))
        {

            GetComponent<AudioSource>().Play();
            scriptBird.kick();
        }
    }

}
