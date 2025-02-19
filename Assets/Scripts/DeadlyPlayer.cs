using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadlyPlayer : MonoBehaviour
{

    public float speed = 3;
    public float jumpSpeed = 8;
    public bool isJumping;

    // Start is called before the first frame update
    void Start()
    {
        isJumping = false;
        jumpSpeed = 8;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        pos.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        

        if (Input.GetKeyDown(KeyCode.Space) && isJumping == false)
        {
            isJumping = true;
        }
        if (isJumping == true)
        {
            pos.y += jumpSpeed * Time.deltaTime;
            jumpSpeed -= 3.5f * Time.deltaTime;
        }
        if (jumpSpeed <= 0)
        {
            isJumping = false;
        }
        if(isJumping == false)
        {
            jumpSpeed = 8;
        }

        transform.position = pos;
    }
}
