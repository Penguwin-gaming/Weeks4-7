using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HexagonSpawner : MonoBehaviour
{

    public GameObject prefab;
    public Button buttonToChangeColour;
    public TextMeshProUGUI numberofClicks;
    int clicks = 0;
    
    public void Spawn()
    {
        GameObject newHexagon = Instantiate(prefab, Random.insideUnitCircle * 4, transform.rotation);
        Hexagon hexagon = newHexagon.GetComponent<Hexagon>();

        buttonToChangeColour.onClick.AddListener(hexagon.ColourChanger);

        hexagon.OnClick.AddListener(AddToClickCounter);
    }

    public void StopListening()
    {
        buttonToChangeColour.onClick.RemoveAllListeners();
    }

    public void AddToClickCounter()
    {
        clicks++;
        numberofClicks.text = clicks.ToString();
    }
}
