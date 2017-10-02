using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {
    private CharacterController controller;
    
    public float moveSpeed = 1; // base player movement speed
    public float turnSpeed = 1; // the speed the player turns
    public float jumpSpeed = 1; // the strength of the player's jump
    // Use this for initialization
    void Start () {
        controller = gameObject.GetComponent<CharacterController>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector3 moveDirection = new Vector3(0, 0, 0);

       // rotates the player left and right. For up and down, see "CameraTurn"
        transform.Rotate(0, Input.GetAxis("Mouse X") * turnSpeed * Time.deltaTime, 0);

        //movement of the player
        moveDirection.x = Input.GetAxis("Horizontal") * moveSpeed;
        moveDirection.z = Input.GetAxis("Vertical") * moveSpeed;

        moveDirection = transform.TransformDirection(moveDirection);

        
        // if the player is holding the sprint button, multiplies movement speed by the sprint multiplier
            controller.Move(moveDirection * Time.deltaTime);

    }
}
