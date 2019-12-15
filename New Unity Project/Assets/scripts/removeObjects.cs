using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removeObjects : MonoBehaviour // used in the scene claner, way behind the mapedge object this cleans of the terrain to keep memory usage stable.
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other) // anything that collied with the trigger box is deleted 
    {
        Destroy(other.gameObject);

    }
}
