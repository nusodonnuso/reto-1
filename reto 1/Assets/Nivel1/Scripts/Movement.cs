using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f;
    public float speedRotation = 10f;
    public float Jump = 5f;
    void Start()
    {
        
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        float jumpInput = Input.GetAxis("Jump");

        Vector3 move = new Vector3(horizontalInput, jumpInput, verticalInput);
        move.Normalize();
        transform.position = transform.position + move * speed * Time.deltaTime;

        if (move != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(move), speedRotation * Time.deltaTime);
        }
    }
}
