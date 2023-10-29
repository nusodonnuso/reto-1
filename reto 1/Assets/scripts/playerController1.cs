using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController1 : MonoBehaviour
{
   private CharacterController player;

   [SerializeField] private float moveSpeed, gravity, fallVelocity, jumpForce;

   private Vector3 axis, movePlayer;

   private void Awake()
   {
    player =GetComponent<CharacterController>();
   }

   private void Update()
   {
    transform.Rotate(0, Input.GetAxis("Mouse X"), 0);
    axis = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    if(axis.magnitude > 1) axis = transform.TransformDirection(axis).normalized;
    else axis = transform.TransformDirection(axis);
    
    movePlayer.x = axis.x;
    movePlayer.z = axis.z;
    setGravity();

    player.Move(movePlayer * moveSpeed * Time.deltaTime);

   }

   private void setGravity()
   {
    if(player.isGrounded)
    {
        fallVelocity = -gravity * Time.deltaTime;
        if (Input.GetKey(KeyCode.Space))
        {
            fallVelocity = jumpForce;
        }
    }
    else
    {
        fallVelocity -= gravity * Time.deltaTime;
    }
    movePlayer.y = fallVelocity;
   }


}
