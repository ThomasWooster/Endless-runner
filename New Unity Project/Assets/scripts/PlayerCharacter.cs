using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCharacter : MonoBehaviour
{
    float jumpSpeed = 8.0f; // vertical speed when jumping
    private float vSpeed = 0.0f; // current vertical velocity
    public float gravity = 12.0f; // how mutch downwards acceleration is applied
    public Text textref; // reference to the text box in the UI in level

    public void incrementScore()// function to be called when the score needs to be changed
    {
        manager.Instance.g_score += 1;// adds 1 to the global managers score
    }


    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 velocity = new Vector3(0, 0, 0); // creates zero vector requird for move function later
        
        CharacterController controller = GetComponent<CharacterController>(); //pulls out character controler into a refrence for use 

        if (controller.isGrounded)// keeps the doenwards speed from growing to mutch and stops the player from sliding off the edge of the plane
        {
            vSpeed = 0.0f;  
        }
        if (Input.GetKeyDown("space") || Input.touchCount > 0) // would be placed in the above if check but isgrounded is to unreliable in how often it goes off you can keep activating the jump
        {
            vSpeed = jumpSpeed; // sets the vertical speed to the jump speed
        }

        vSpeed -= gravity * Time.deltaTime; // applies the graviy acceleration tot he vertical speed giving the player gravity. is scaled to delta time.
        velocity.y = vSpeed; // the vertcal speed is applied to the velocity, whitch is still there for futer expasion of motion forwars and backwards as well as for the move function 

        controller.Move(velocity * Time.deltaTime); // the player controler move function is used, the velocity vector is used here and is smoothed by the delta time


        textref.text = "Score:" + manager.Instance.g_score; // the score is added to the text box in the ui here, sot he player can see there score.
    }
}
