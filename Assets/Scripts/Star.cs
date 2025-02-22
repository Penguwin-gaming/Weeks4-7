using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    //declares a rotation speed float that will randomize on the start of the scene
    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rotationSpeed = Random.Range(3f, 9f);
    }

    // Update is called once per frame
    void Update()
    {
        //rotates the star based on the rotation speed that was randomized above
        Vector3 rot = transform.eulerAngles;
        rot.z = rotationSpeed;
        transform.eulerAngles += rot;

    }
}
