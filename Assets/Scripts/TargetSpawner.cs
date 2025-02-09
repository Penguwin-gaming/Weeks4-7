using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    public GameObject targetPrefab;
    public int howManyTargets = 5;
    public GameObject victoryGraphics;
    public SpriteRenderer victorySprite;
    public List<GameObject> targets;

    // Start is called before the first frame update
    void Start()
    {
        victorySprite.enabled = false;
        victoryGraphics.SetActive(false);

        targets = new List<GameObject>();
        for(int i = 0; i < howManyTargets; i++)
        {
            GameObject newTarget = Instantiate(targetPrefab);
            newTarget.transform.position = Random.insideUnitCircle * 5;

            Targetscript t = newTarget.GetComponent<Targetscript>();
            t.spawner = this;

            targets.Add(newTarget);
        }
    }

    public void TargetHit(GameObject t)
    {
        targets.Remove(t);
    }
    // Update is called once per frame
    void Update()
    {
        if (targets.Count == 0)
        {
            victorySprite.enabled = true;
            victoryGraphics.SetActive(true);
        }
    }
}
