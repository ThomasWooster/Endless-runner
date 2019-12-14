using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCharacter : MonoBehaviour
{
    float jumpSpeed = 8.0f;
    float score;
    float speed = 5.0f;
    private float vSpeed = 0.0f; // current vertical velocity

    public float gravity = 12.0f;
    public Text textref;

    public void incrementScore(int value)
    {
        score += value;
    }


    // Start is called before the first frame update
    void Start()
    {
        score = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 velocity;
        velocity.x = 0;
        velocity.y = 0;
        velocity.z = 0;
        var controller = GetComponent<CharacterController>();

        if (controller.isGrounded)
        {
            vSpeed = 0.0f;  
        }
        if (Input.GetKeyDown("space"))
        {
            vSpeed = jumpSpeed;
        }

        vSpeed -= gravity * Time.deltaTime;
        velocity.y = vSpeed;
        //print(vSpeed);

        controller.Move(velocity * Time.deltaTime);


        textref.text = "Score:" + score;
    }
}
