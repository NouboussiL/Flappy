using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePipes : MonoBehaviour
{
    public Vector2 movement;
    public GameObject pipe1Up, pipe1Down,box;
    private Transform pipe1UpOriginal, pipe1DownOriginal,boxOriginal;
    private Vector2 siz, leftCameraBottomBorder, rightBottomCameraBorder, leftCameraTopBorder;
    // Start is called before the first frame update
    void Start()
    {


        boxOriginal = box.transform;
        pipe1UpOriginal = pipe1Up.transform;
        pipe1DownOriginal = pipe1Down.transform;
        leftCameraBottomBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0));
        rightBottomCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0));
        leftCameraTopBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0));
    }

    // Update is called once per frame
    void Update()
    {
        pipe1Up.GetComponent<Rigidbody2D>().velocity = movement;
        pipe1Down.GetComponent<Rigidbody2D>().velocity = movement;
        box.GetComponent<Rigidbody2D>().velocity = movement;
        siz.x = pipe1Up.GetComponent<SpriteRenderer>().bounds.size.x;
        siz.y = pipe1Up.GetComponent<SpriteRenderer>().bounds.size.y;
        if (pipe1Down.transform.position.x < leftCameraBottomBorder.x - (siz.x / 2)) moveToRightPipe();
    }

    void moveToRightPipe()
    {
        float posY = 0.0f;
        float randomY = Random.Range(1, 4) - 2;
        float posX = rightBottomCameraBorder.x + (siz.x / 2);
        posY = pipe1UpOriginal.transform.position.y + randomY;
        Vector3 tmpPos = new Vector3(posX, posY, pipe1UpOriginal.position.z);
        pipe1Up.transform.position = tmpPos;

        posY = pipe1DownOriginal.transform.position.y + randomY;
        tmpPos = new Vector3(posX, posY, pipe1DownOriginal.position.z);
        pipe1Down.transform.position = tmpPos;


        posY = box.transform.position.y + randomY;
        tmpPos = new Vector3(posX, posY, boxOriginal.position.z);
        box.transform.position = tmpPos;
            
        if(pipe1Down.transform.position.y < leftCameraBottomBorder.y  - (siz.y/2)  || pipe1Up.transform.position.y > leftCameraTopBorder.y + (siz.y/2)) moveToRightPipe();
    }
}
