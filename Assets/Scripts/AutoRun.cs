using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRun : MonoBehaviour
{
    public Rigidbody2D playerRB;
    public float runSpeed;
    public float jumpForce;
    public bool isOnGround;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerRB.velocity = Vector2.right * runSpeed;

        if (Input.GetKey(KeyCode.Space) && isOnGround)
        {
            playerRB.AddForce(new Vector2(0, jumpForce), ForceMode2D.Force);
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = false;
        }
    }
}
