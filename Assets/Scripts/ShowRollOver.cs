using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShowRollOver : MonoBehaviour
{
    public Image image;

    public Sprite highlight;
    public Sprite normal;

    public TextMeshProUGUI reactionText;

    public void MouseIsOverUs()
    {
        image.sprite = highlight;
        reactionText.text = "Blergh!!!";
    }

    public void MouseIsNotOverUs()
    {
        image.sprite = normal;
        reactionText.text = "Yummers!!!";
    }
}
