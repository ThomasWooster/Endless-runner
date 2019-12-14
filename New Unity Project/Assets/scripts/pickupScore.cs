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
        PlayerCharacter playerRef = other.gameObject.GetComponent<PlayerCharacter>();

        playerRef.incrementScore(1);

        Destroy(gameObject);
    }
}
