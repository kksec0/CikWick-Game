using System.Numerics;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 5f;
    private Rigidbody rb;
    private bool isGrounded;
    public float groundCheckDistance = 0.665f;
    public LayerMask groundLayer; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
    void Update()
    {

        isGrounded = Physics.Raycast(
            transform.position,
            UnityEngine.Vector3.down,
            groundCheckDistance,
            groundLayer
        );





        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        UnityEngine.Vector3 movement = new UnityEngine.Vector3(horizontal, 0f, vertical);
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(
                UnityEngine.Vector3.up * jumpForce,
                ForceMode.Impulse
            );
            isGrounded = false;
        }
    
    
    
    }
     
}
