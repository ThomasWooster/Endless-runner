using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerCharacter playerRef = other.gameObject.GetComponent<PlayerCharacter>(); // pulls the player component, if they have one

        playerRef.incrementScore(); // now that it is a player component we call the increment score function

        Destroy(gameObject); // finaly we destroy the pickup its self
    }
}
