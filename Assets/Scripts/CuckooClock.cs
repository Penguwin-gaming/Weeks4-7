using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class CuckooClock : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;
    public SpriteRenderer sr;
    public float handRotation;
    public float turnSpeed = 5;
    public bool chirping = false;
    public float hour = 0;
    public float chimes = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, -turnSpeed * Time.deltaTime);
        handRotation += turnSpeed * Time.deltaTime;

        if (handRotation >= 30)
        {
            chirping = true;
            handRotation = 0;
            hour += 1;
        }
        if (chirping == true)
        {
            audioSource.PlayOneShot(clip);
            sr.enabled = true;
            chimes += 1;
        }
        if (audioSource.isPlaying == false)
        {
            sr.enabled = false;
        }
        if (hour == 12)
        {
            hour = 0;
        }
        if(chimes == hour)
        {
            chirping = false;
            chimes = 0;
        }
       
    }
}
