using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CometSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //seperate function which will spawn a comet from the comet script when a button is pressed that calls this function
    //i was having trouble coming up with spawning multiple comets based on a counter set by the player (in the planning) so i decided to forego it
    public void SpawnTarget(GameObject c)
    {
        GameObject comet = Instantiate(c);
        comet.transform.position = new Vector3(-15f, Random.Range(-4, 4), 0f);

    }
}
