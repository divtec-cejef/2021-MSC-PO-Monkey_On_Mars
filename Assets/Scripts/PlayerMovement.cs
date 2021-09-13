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

    public Animator animator;
    public SpriteRenderer spriteRenderer;

    public int nombreInsert;

    public Transform posY;
    public float posMax;

    void Update()
    {
        //initialise le "isGrounded" pour savoir quand est-ce que le personne touche le sol
        isGrounded = Physics2D.OverlapCircle(groundCheckRight.position, groundCheckRadius, collisionLayers) || Physics2D.OverlapCircle(groundCheckLeft.position, groundCheckRadius, collisionLayers);

        //initialise variable pour les mouvement gauche droite
        horizontalMovement = Input.GetAxis("Horizontal") * moveSpeedPlayer * Time.deltaTime;

        //test si le bouton de saut est press� ou non
        if (Input.GetButtonDown("Jump"))
        {
            //compte le nombre de fois que la touche pour sauter est press�e
            nombreInsert++;
        }
    }

    void FixedUpdate()
    {
        //lance ce qu'il faut pour que le joueur se d�place de gauche � droite
        MovePlayer(horizontalMovement);

        Flip(rb.velocity.x);

        animator.SetFloat("speed", rb.velocity.x);
        float characterVelocity = Mathf.Abs(rb.velocity.x);
    }

    void MovePlayer(float _horizontalMovement)
    {
        Vector3 targetVelocity = new Vector2(_horizontalMovement, rb.velocity.y);
        rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, .05f);

        //si il touche le sol
        if (isGrounded == true)
        {
            //remet la variable du nombre de saut � 0
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

        //mets posMax au minimum au d�but de la partie
        if (isGrounded == true)
        {
            posMax = -5;
        }

        //si il est en l'air l'animation du jetpack se lance
        if (isGrounded == false)
        {
            animator.SetBool("IsInAir", true);
            posMax = posY.transform.position.y;
        }
        //sinon l'animation s'arr�te
        else
        {
            animator.SetBool("IsInAir", false);
            animator.SetFloat("speed", rb.velocity.x);
        }
        
        //pour ne pas qu'il rebondisse
        if (numberJump == 1)
        {
            firstJump = true;
        }   

        if (numberJump != 0)
        {
            clonePlateforme = false;
        }

        //pour que le singe ne rebondisse pas
        if (nombreInsert < 1)
        {
            isJumping = false;
        }
        else
        {
            isJumping = true;
            nombreInsert = 0;
        }

        //si le joueur touche le sol
        if (isGrounded == true)
        {
            
            //si le bouton de saut est press�
            if (isJumping == true)
            {
                //fait un saut
                jumpForce = 600;
                rb.AddForce(new Vector2(0f, jumpForce));
                isJumping = false;
                numberJump = 1;
                
            }
        }
    }

    //sert � g�rer si les gizmos touchent une zone de colision ou non
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheckLeft.position, groundCheckRadius);
        Gizmos.DrawWireSphere(groundCheckRight.position, groundCheckRadius);
    }

    //retourne le personnage si il va en positif ou en n�gatif sur l'axe x
    void Flip(float _velocity)
    {
        if (_velocity > 0.1f)
        {
            spriteRenderer.flipX = false;
        }
        else if (_velocity < -0.1f)
        {
            spriteRenderer.flipX = true;
        }
    }
}