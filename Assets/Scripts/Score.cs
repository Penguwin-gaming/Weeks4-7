using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{

    public GameObject gameOverScreen;
    public TextMeshProUGUI score;
    int scoreValue = 0;
    bool isPlaying = true;

    // Start is called before the first frame update
    void Start()
    {
        score.text = scoreValue.ToString();
        gameOverScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isPlaying == true)
        {
            scoreValue++;
            score.text = scoreValue.ToString();
        }

        if (scoreValue > 10)
        {
            gameOverScreen.SetActive(true);
            isPlaying = false;
        }
        if (Input.GetKeyDown(KeyCode.Space) && isPlaying == false)
        {
            scoreValue = 0;
            isPlaying = true;
            score.text = scoreValue.ToString();
            gameOverScreen.SetActive(false);
        }
    }
}
