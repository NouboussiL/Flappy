using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBkR : MonoBehaviour
{
    public Vector2 movement;
    public float positionRestartX;
    private Vector2 siz;
    private Vector3 rightBottomrCameraBorder;

    private void Start()
    {
        rightBottomrCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = movement;
        siz.y = gameObject.GetComponent<SpriteRenderer>().bounds.size.y;
        siz.x = gameObject.GetComponent<SpriteRenderer>().bounds.size.x;

        //If background exits teh screen 
        //Set x positoin with the original backGround3 x position
        if (transform.position.x > rightBottomrCameraBorder.x +(siz.x / 2))
            transform.position = new Vector3(positionRestartX, transform.position.y, transform.position.z);
    }
}
