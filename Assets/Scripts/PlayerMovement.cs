using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeedPlayer;
    public float jumpForce;
    public int numberJump;

    public Transform groundCheckLeft;
    public Transform groundCheckRight;
    public float groundCheckRadius;
    public LayerMask collisionLayers;

    public bool isJumping;
    public bool isGrounded;

    public Rigidbody2D rb;
    private Vector3 velocity = Vector3.zero;
    private float horizontalMovement;

void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheckRight.position, groundCheckRadius, collisionLayers) || Physics2D.OverlapCircle(groundCheckLeft.position, groundCheckRadius, collisionLayers);

        horizontalMovement = Input.GetAxis("Horizontal") * moveSpeedPlayer * Time.deltaTime;
        
        if (Input.GetButtonDown("Jump"))
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

        if (isGrounded == true)
        {
            numberJump = 0;
        }
        if (isGrounded == true || numberJump < 3)
        {
            if (isJumping == true)
            {
                jumpForce = 200;
                rb.AddForce(new Vector2(0f, jumpForce));
                isJumping = false;
                numberJump++;
            }
        }
    }
    
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheckLeft.position, groundCheckRadius);
        Gizmos.DrawWireSphere(groundCheckRight.position, groundCheckRadius);
    }
    
}
