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

    public GameObject plateformeClonable;
    public bool clonePlateforme;
    public bool firstJump = false;
    public Transform transformMe;
    public Transform transformPalm;
    public GameObject monkey;

    void Update()
    {
        //initialise le "isGrounded" pour savoir quand est-ce que le personne touche le sol
        isGrounded = Physics2D.OverlapCircle(groundCheckRight.position, groundCheckRadius, collisionLayers) || Physics2D.OverlapCircle(groundCheckLeft.position, groundCheckRadius, collisionLayers);

        //initialise variable pour les mouvement gauche droite
        horizontalMovement = Input.GetAxis("Horizontal") * moveSpeedPlayer * Time.deltaTime;

        //test si le bouton de saut est pressé ou non
        if (Input.GetButtonDown("Jump"))
        {
            isJumping = true;
        }

    }

    void FixedUpdate()
    {
        //lance ce qu'il faut pour que le joueur se déplace de gauche à droite
        MovePlayer(horizontalMovement);
    }

    void MovePlayer(float _horizontalMovement)
    {
        Vector3 targetVelocity = new Vector2(_horizontalMovement, rb.velocity.y);
        rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, .05f);

        //si il touche le sol
        if (isGrounded == true)
        {
            //remets la variable du nombre de saut à 0
            numberJump = 0;


            if (clonePlateforme == false)
            {
               
                if (monkey.transform.position.y >= (transformMe.position.y))
                {

                    if (firstJump == true)
                    {

                        //clone une plateforme quand il touche le sol
                        GameObject clone;
                        clone = Instantiate(plateformeClonable, new Vector3(transformPalm.position.x * (-100), transformMe.position.y, transformMe.position.z), transform.rotation);
                        clonePlateforme = true;
                    }
                }
            }

        }
        if (numberJump == 2)
        {
            firstJump = true;
        }

        if (numberJump != 0)
        {
            clonePlateforme = false;
        }

        //si le joueur touche le sol ou le nombre de sauts est plus petit que 3
        if (isGrounded == true || numberJump < 3)
        {
            //alors si le boutton de saut est pressé
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

    //sert à gérer si les gizmos touchent une zone de colision ou non
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheckLeft.position, groundCheckRadius);
        Gizmos.DrawWireSphere(groundCheckRight.position, groundCheckRadius);
    }
}