using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Comet : MonoBehaviour
{
    //declares the variables that can be changed by the UI elements
    public float speed;
    public float scale;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 12); 
    }

    // Update is called once per frame
    void Update()
    {
        //moves the comet from the left to the right side of the screen, set at a specific scale. Then after some time stated above, destroys it
        Vector2 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        Vector2 sca = transform.localScale;
        sca.x = scale;
        sca.y = scale;
        transform.localScale = sca;

    }

    //changes the scaling and speed of the comet when the sliders are moved
    public void cSpeed(float v)
    {
        speed = v;
    }

    public void cScale(float s)
    {
        scale = s;
    }
}
