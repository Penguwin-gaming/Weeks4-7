using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    public float speed = -1;

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(-4, -1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
