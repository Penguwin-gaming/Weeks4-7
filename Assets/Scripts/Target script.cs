using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targetscript : MonoBehaviour
{
    public float speed = 1;
    public AnimationCurve curve;
    public SpriteRenderer sr;
    public Color col;
    float t;
    bool isDead = false;
    public TargetSpawner spawner;

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(1, 5);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        pos.x += speed * Time.deltaTime;

        if(screenPos.x < 0)
        {
            speed = speed * -1;
            pos.x = Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x;
        }

        if(screenPos.x > Screen.width)
        {
            speed = speed * -1;
            pos.x = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x;
        }

        transform.position = pos;

        if(Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if(sr.bounds.Contains(mousePos))
            {
                sr.color = col;
                isDead = true;
                Destroy(gameObject, 1);
                spawner.TargetHit(gameObject);
            }
        }

        if (isDead == true)
        {
            t += Time.deltaTime;
            transform.localScale = Vector3.one * curve.Evaluate(t);
        }
    }
}
