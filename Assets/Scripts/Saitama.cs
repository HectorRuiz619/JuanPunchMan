using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saitama : MonoBehaviour
{
    [SerializeField] float MoveSpeed = 5.0f;  // Velocidad de movimiento normal
    [SerializeField] float RunSpeed = 10.0f;  // Velocidad de correr
    [SerializeField] float jumpForce = 7.0f;  // Fuerza del salto
    private Rigidbody2D rb;                   // Componente Rigidbody2D del sprite
    private bool isGrounded;                  // Verifica si el personaje está en el suelo
    private bool isJumping;
    private int jumpCount = 0;                // Contador para los saltos
    private int maxJumps = 2;                 // Máximo número de saltos permitidos (doble salto)
    float horizontalInput;
    private bool isRunning;                   // Indica si el personaje está corriendo

    private Animator animator;                // Referencia al Animator del personaje
    private bool facingRight = true;          // Para controlar la dirección del sprite
      
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        // Verificar si la tecla "F" está presionada para correr
        if (Input.GetKey(KeyCode.F))
        {
            isRunning = true;
        }
        else
        {
            isRunning = false;
        }

        FlipSprite();

        // Permitir salto si está en el suelo o si no ha excedido el máximo de saltos
        if (Input.GetButtonDown("Jump") && (isGrounded || jumpCount < maxJumps))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            isGrounded = false;
            jumpCount++;  // Aumentar el contador de saltos
            animator.SetBool("isJumping", true);
        }

        // Actualizar el parámetro "isRunning" en el Animator para la animación
        animator.SetBool("isRunning", isRunning);
    }

    private void FixedUpdate()
    {
        // Cambiar la velocidad según si está corriendo o no
        float currentSpeed = isRunning ? RunSpeed : MoveSpeed;
        rb.velocity = new Vector2(horizontalInput * currentSpeed, rb.velocity.y);

        // Actualizar los valores del Animator para el movimiento horizontal
        animator.SetFloat("xVelocity", Mathf.Abs(rb.velocity.x));
        animator.SetFloat("yVelocity", rb.velocity.y);
    }

    void FlipSprite()
    {
        if (facingRight && horizontalInput < 0f || !facingRight && horizontalInput > 0f)
        {
            facingRight = !facingRight;
            Vector3 ls = transform.localScale;
            ls.x *= -1f;
            transform.localScale = ls;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isGrounded = true;
        jumpCount = 0;  // Reiniciar el contador de saltos al tocar el suelo
        animator.SetBool("isJumping", false);
    }
}
