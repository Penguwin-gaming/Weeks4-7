using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Telescope : MonoBehaviour
{
    //setting the base values of the telescope sprite that will start at the center of the screen
    public float xCoord = 0;
    public float yCoord = 0;

    // Start is called before the first frame update
    void Start()
    {
        //resets the coordinates of the telescope when restarting the scene (just in case the telescope is moved off screen)
        xCoord = 0;
        yCoord = 0;
}

    // Update is called once per frame
    void Update()
    {
        //moves the telescope on the x and y axis based on its values from the UI elements
        Vector2 pos = transform.position;
        pos.x = xCoord;
        pos.y = yCoord;
        transform.position = pos;

    }

    //the two functions that the UI elements will activate when their values are changed (the sliders are moved)
    public void Hor(float h)
    {
        xCoord = h;
    }
    
    public void Ver(float v)
    {
        yCoord = v;
    }
}
