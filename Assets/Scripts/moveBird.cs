using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBird : MonoBehaviour
{
    private Vector2 leftBottomCameraBorder;
    private Vector2 leftTopCameraBorder;
    private Vector2 siz;
    public float thrust = 325.0f;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        leftBottomCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0));
        leftTopCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0));
    }

    // Update is called once per frame
    void Update()
    {

        siz.x = gameObject.GetComponent<SpriteRenderer>().bounds.size.x;
        siz.y = gameObject.GetComponent<SpriteRenderer>().bounds.size.y;

        if (transform.position.y < leftBottomCameraBorder.y + (siz.y / 2))
        {
            transform.position = new Vector3(transform.position.x, leftBottomCameraBorder.y + (siz.y / 2), transform.position.x);
        }

        if (transform.position.y > leftTopCameraBorder.y - (siz.y / 2))
        {
            transform.position = new Vector3(transform.position.x, leftTopCameraBorder.y - (siz.y/2), transform.position.x);
        }

  
        /*
        var dir = rb.velocity;
        Quaternion newRotation;
        if (dir != Vector2.zero)

        {
            newRotation = Quaternion.LookRotation(new Vector3(dir.x, dir.y, 0));
            newRotation = new Quaternion(newRotation.y, newRotation.y, newRotation.x > 0 ? -0.45f:0.45f, newRotation.w);
            transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, Time.deltaTime*gameObject.GetComponent<Rigidbody2D>().gravityScale*10);// newRotation;

        }
        else
            transform.rotation = new Quaternion(0, 0, transform.rotation.z > 0 ? 0.7f : -0.7f, 0);
            */
    }

    public void kick()
    {
        rb.velocity = new Vector2(0, 0);
        rb.AddForce(new Vector2(0,1) * thrust*gameObject.GetComponent<Rigidbody2D>().gravityScale);
    }

    public void die()
    {
        Quaternion newRotation = new Quaternion(0, 0, -1f, 0);
        transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, Time.deltaTime*30);
    }
}
