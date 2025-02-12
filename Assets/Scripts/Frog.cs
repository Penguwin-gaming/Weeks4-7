using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Frog : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;
    public GameObject victory;
    public int speed = 1;
    public bool isPlaying;


    // Start is called before the first frame update
    void Start()
    {
        isPlaying = true;
        victory.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        if (Input.GetKeyDown(KeyCode.W) && isPlaying == true)
        {
            pos.y = pos.y + speed;
        }
        if (Input.GetKeyDown(KeyCode.S) && isPlaying == true)
        {
            pos.y = pos.y - speed;
        }
        if (Input.GetKeyDown(KeyCode.A) && isPlaying == true)
        {
            pos.x = pos.x - speed;
        }
        if (Input.GetKeyDown(KeyCode.D) && isPlaying == true)
        {
            pos.x = pos.x + speed;
        }

        transform.position = pos;

        if(pos.y >= 4 && isPlaying == true)
        {
            victory.SetActive(true);
            speed = 0;
            audioSource.PlayOneShot(clip);
            isPlaying = false;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isPlaying == false)
        {
            pos.y = pos.y - 8;
            isPlaying = true;
        }    
    }
}
