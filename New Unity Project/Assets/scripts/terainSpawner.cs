using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terainSpawner : MonoBehaviour // attached to a collision mesh trigger as the spawn point, multiple spawners can be used with differet objects and tims.
{
    public float timer; // how long between eatch spawning, can be changed in editor
    public GameObject prefabTerain; // what object or map cluster is to be spawned, can be changed from the editor
    float timerTrigger;

    // Start is called before the first frame update
    void Start()
    {
        timerTrigger = timer; // the timer holds its own trigger because it imediatly fires.
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; // runs the timer

        if (timer >= timerTrigger) // checks if the timer has triggerd
        {
            timer = 0.0f; //  resets the timer
            Instantiate(prefabTerain, transform.position, Quaternion.identity); // instancsiates/spawns the selected terain at the spawners location with an identity rotation
        }
    }
}
