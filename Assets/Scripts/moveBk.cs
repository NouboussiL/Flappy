using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBk : MonoBehaviour
{
    public Vector2 movement;
    public float positionRestartX;
    private Vector2 siz;
    private Vector3 leftBottomCameraBorder;

    private void Start()
    {
        leftBottomCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = movement;
        siz.y = gameObject.GetComponent<SpriteRenderer>().bounds.size.y;
        siz.x = gameObject.GetComponent<SpriteRenderer>().bounds.size.x;

        //If background exits teh screen 
        //Set x positoin with the original backGround3 x position
        if (transform.position.x < leftBottomCameraBorder.x - (siz.x / 2))
            transform.position = new Vector3(positionRestartX, transform.position.y, transform.position.z);
    }
}
