using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 1000f;
    Vector3 velocity;
    public float gravity = -9.81f;
    public Transform player;
    public Transform feet;
    public Transform itemHolder;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;
    public float jumpHeight = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(feet.position, groundDistance, groundMask);
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            Crouch();
        }else if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            GetUp();
        }
    }
    void Crouch()
    {
        player.localScale = new Vector3(0.6f, 0.4f, 0.6f);
        itemHolder.localScale = new Vector3(1f, 2f, 1f);
    }
    void GetUp()
    {
        player.localScale = new Vector3(0.6f, 0.8f, 0.6f);
        itemHolder.localScale = new Vector3(1f, 1f, 1f);
    }
}
