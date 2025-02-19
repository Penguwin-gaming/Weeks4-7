using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadlyPlayer : MonoBehaviour
{

    public float speed = 3;
    public float gravity = 1;
    public float jumpSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        pos.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        transform.position = pos;
    }
}
