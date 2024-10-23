using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnApple : MonoBehaviour
{
    public GameObject CollectableApple;
    int time = 0;

    // Update is called once per frame
    void Update()
    {
        if ( time == 1000)
        {
            Vector3 randomPosition = new Vector3(Random.Range(0, 5), Random.Range(0, 5), 0);
            time = 0;
            Instantiate(CollectableApple, randomPosition, Quaternion.Euler(0,0,0));
        }
        else
        {
            time += 1;
        }
    }
}
