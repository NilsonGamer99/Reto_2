using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    public float sprintSpeed = 10f;
    public bool isGrounded = false;

    void Update()
    {
        // Movimiento horizontal
        transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, 0) * Time.deltaTime * moveSpeed;

        // Salto
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }

        // Sprint
        if (Input.GetKey(KeyCode.D))
        {
            moveSpeed = sprintSpeed;
        }
        else
        {
            moveSpeed = 5f;
        }

        // Ataque
        if (Input.GetKeyDown(KeyCode.A))
        {
            // Código para atacar
        }

        // Ataque especial
        if (Input.GetKeyDown(KeyCode.W))
        {
            // Código para ataque especial
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}