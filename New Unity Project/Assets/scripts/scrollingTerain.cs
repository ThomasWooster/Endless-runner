using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollingTerain : MonoBehaviour // placed in any object that needs to move trough the level. on terain goups only the root needs this script
{
    

    public float speed = 4.0f; // the speed of the level, can be attached to an outside number for variance.
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0); // translate is used for movment

        
    }
}
