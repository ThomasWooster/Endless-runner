using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terainSpawner : MonoBehaviour
{
    float timer;
    public GameObject prefabTerain;

    // Start is called before the first frame update
    void Start()
    {
        timer = 7.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 7)
        {
            print("spawn");
            timer = 0.0f;
            Instantiate(prefabTerain, transform.position, Quaternion.identity);
        }
    }
}
