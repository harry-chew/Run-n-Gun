using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private bool isGrounded;
    [SerializeField] private float jumpForce;

    private void Awake()
    {
        GetComponent<PlayerCollisions>().OnGround += Grounded;
        isGrounded = true;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            Jump();
        }
    }
    private void FixedUpdate()
    {

    }

    private void Jump()
    {
        Debug.Log("JUMP");
        gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce);
        isGrounded = false;
    }

    private void Grounded()
    {
        isGrounded = true;
    }
}
