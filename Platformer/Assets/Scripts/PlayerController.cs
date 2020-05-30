using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D playerRb;

    [SerializeField] float horizontalInput;
    [SerializeField] float MoveSpeed;
    [SerializeField] float JumpForce;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        if (horizontalInput > 0)
        {
            playerRb.AddForce(Vector2.right * MoveSpeed);
        }
        else if (horizontalInput < 0)
        {
            playerRb.AddForce(Vector2.left * MoveSpeed);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(Vector2.up * JumpForce);
        }
    }
}
