﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollingTerain : MonoBehaviour
{
    

    float speed = 4.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);

        
    }
}
