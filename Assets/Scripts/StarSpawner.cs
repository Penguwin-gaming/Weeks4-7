using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSpawner : MonoBehaviour
{
    //previous code from week 6 readings to spawn in the stars in a random position, they do not move or are interactable
    public GameObject starPrefab;
    public int starAmount = 30;

    // Start is called before the first frame update
    void Start()
    {
        //spawns the stars in a circle with a radius of 5 units
        for (int i = 0; i < starAmount; i++)
        {
            GameObject newStar = Instantiate(starPrefab);
            newStar.transform.position = Random.insideUnitCircle * 8;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
