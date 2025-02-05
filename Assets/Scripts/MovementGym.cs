using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementGym : MonoBehaviour
{

    public float speed = 5;
    public GameObject speechBubble;
    public GameObject words1;
    public GameObject words2;
    public GameObject words3;
    public GameObject words4;
    public GameObject words5;
    public GameObject words6;
    public int randomBubble;

    // Start is called before the first frame update
    void Start()
    {
        speechBubble.SetActive(false);
        randomBubble = Random.Range(0, 5);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        pos.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        pos.y += Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;

        transform.position = pos; 

        if(pos.x < -1)
        {
            speechBubble.SetActive(true);

            if(randomBubble == 0)
            {
                words1.SetActive(true);
            } else if (randomBubble == 1)
            {
                words2.SetActive(true);
            } else if (randomBubble == 2)
            {
                words3.SetActive(true);
            } else if (randomBubble == 3)
            {
                words4.SetActive(true);
            } else if (randomBubble == 4)
            {
                words5.SetActive(true);
            } else if (randomBubble == 5)
            {
                words6.SetActive(true);
            }

        } else
        {
            words1.SetActive(false);
            words2.SetActive(false);
            words3.SetActive(false);
            words4.SetActive(false);
            words5.SetActive(false);
            words6.SetActive(false);
            speechBubble.SetActive(false);
            randomBubble = Random.Range(0, 6);
        }
    }
}
