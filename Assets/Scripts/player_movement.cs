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

            // Determine dominant direction
            if (Mathf.Abs(moveInput.x) > Mathf.Abs(moveInput.y))
            {
                // Horizontal movement
                float moveX = moveInput.x > 0 ? 1f : -1f;
                animator.SetFloat("MoveX", moveX);
                animator.SetFloat("MoveY", 0f);
                Debug.Log("Set MoveX: " + moveX + ", MoveY: 0");

                // 🔁 Flip sprite based on horizontal direction
                if (moveInput.x > 0)
                    transform.localScale = new Vector3(-1f, 1f, 1f);  // Facing right
                else
                    transform.localScale = new Vector3(1f, 1f, 1f);   // Facing left
            }
            else
            {
                // Vertical movement
                float moveY = moveInput.y > 0 ? 1f : -1f;
                animator.SetFloat("MoveX", 0f);
                animator.SetFloat("MoveY", moveY);
                Debug.Log("Set MoveX: 0, MoveY: " + moveY);
            }
        }
        else
        {
            animator.SetBool("isMoving", false);
            Debug.Log("Player is idle");
        }
    }

    public void Move(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }
}