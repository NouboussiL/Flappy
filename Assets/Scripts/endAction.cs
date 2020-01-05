using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endAction : MonoBehaviour
{
    private int compt = 0;
    public void die()
    {
        Destroy(gameObject.GetComponent<touchAction>());
        if (compt++ < 1) gameObject.GetComponent<moveBird>().die();
        gameManager.Instance.dead();
        Invoke("goScene4", 0.5f);

    }

    public void goScene4() => SceneManager.LoadScene("scene4-GameOver");
}
