using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //initialisation des variables
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
        //initialise le "isGrounded" pour savoir quand est-ce que le personne touche le sol
        isGrounded = Physics2D.OverlapCircle(groundCheckRight.position, groundCheckRadius, collisionLayers) || Physics2D.OverlapCircle(groundCheckLeft.position, groundCheckRadius, collisionLayers);

        //initialise variable pour les mouvement gauche droite
        horizontalMovement = Input.GetAxis("Horizontal") * moveSpeedPlayer * Time.deltaTime;

        //test si le boutton de saut est prèssé ou non
        if (Input.GetButtonDown("Jump"))
        {
            isJumping = true;
        }

    }

    void FixedUpdate()
    {
        //lance ce qu'il faut pour que le joueur ce déplace de gauche à droite
        MovePlayer(horizontalMovement);
    }

    void MovePlayer(float _horizontalMovement)
    {
        Vector3 targetVelocity = new Vector2(_horizontalMovement, rb.velocity.y);
        rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, .05f);

        //si il touche le sol
        if (isGrounded == true)
        {
            //remets la variable du nobre de saut à 0
            numberJump = 0;
        }

        //si le joueur touche le sol ou le nombr ede saut est plus petit que 3
        if (isGrounded == true || numberJump < 3)
        {
            //alors si le boutton de saut est prèssé
            if (isJumping == true)
            {
                //fait un saut
                jumpForce = 250;
                rb.AddForce(new Vector2(0f, jumpForce));
                isJumping = false;
                numberJump++;
            }
        }
    }

    //sert à gère si les gizmos touche une zone de colision ou non
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheckLeft.position, groundCheckRadius);
        Gizmos.DrawWireSphere(groundCheckRight.position, groundCheckRadius);
    }
}