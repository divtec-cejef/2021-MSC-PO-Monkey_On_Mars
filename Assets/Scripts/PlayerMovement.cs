using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeedPlayer;
    public float jumpForce;

    public bool isJumping;

    public Rigidbody2D rb;
    private Vector3 velocity = Vector3.zero;
    private float horizontalMovement;
    private float rightTrigger;

    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal") * moveSpeedPlayer * Time.deltaTime * 14;
        rightTrigger = Input.GetAxis("Right Trigger");

        if (Input.GetButtonDown("Jump"))
        {
            isJumping = true;
        }

        if (rightTrigger > 0)
        {
            isJumping = true;
        }

    }

    void FixedUpdate()
    {
        MovePlayer(horizontalMovement);
    }

    void MovePlayer(float _horizontalMovement)
    {
        Vector3 targetVelocity = new Vector2(_horizontalMovement, rb.velocity.y);
        rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, .05f);

        if(isJumping == true)
        {
            rb.AddForce(new Vector2(0f, jumpForce));
            isJumping = false; 
        }
    }
}
