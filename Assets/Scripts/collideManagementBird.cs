using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collideManagementBird : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.CompareTag("pipe") && collision.gameObject.CompareTag("Bird"))
        {
            collision.gameObject.GetComponent<endAction>().die();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (gameObject.CompareTag("box") && collision.gameObject.CompareTag("Bird"))
        {
            gameManager.Instance.addScore();

        }
    }
}