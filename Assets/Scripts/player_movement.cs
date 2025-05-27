using UnityEngine;
using UnityEngine.InputSystem;

public class player_movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 moveInput;
    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        rb.linearVelocity = moveInput * moveSpeed;

        if (moveInput != Vector2.zero)
        {
            animator.SetBool("isMoving", true);

            if (Mathf.Abs(moveInput.x) > Mathf.Abs(moveInput.y))
            {
                // Left-Right movement
                float moveX = moveInput.x > 0 ? 1f : -1f;
                animator.SetFloat("MoveX", moveX);
                animator.SetFloat("MoveY", 0f);

                // Flip sprite
                if (moveInput.x > 0)
                    transform.localScale = new Vector3(-1f, 1f, 1f);  // Facing right
                else
                    transform.localScale = new Vector3(1f, 1f, 1f);   // Facing left
            }
            else
            {
                // Up-Down movement
                float moveY = moveInput.y > 0 ? 1f : -1f;
                animator.SetFloat("MoveX", 0f);
                animator.SetFloat("MoveY", moveY);
            }
        }
        else
        {
            animator.SetBool("isMoving", false);
        }
    }

    public void Move(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }
}