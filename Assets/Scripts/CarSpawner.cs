using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{

    public GameObject carPrefab;
    public int carAmount = 6;
    public List<GameObject> cars;

    // Start is called before the first frame update
    void Start()
    {
        cars = new List<GameObject>();
        for(int i = 0; i < carAmount; i++)
        {
            GameObject newCar = Instantiate(carPrefab);
            newCar.transform.position = Random.insideUnitCircle * 3;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
