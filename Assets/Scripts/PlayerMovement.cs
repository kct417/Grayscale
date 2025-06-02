using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 moveInput;
    private Animator animator;
    private Transform spriteTransform;
    [SerializeField] public AudioSource walkingSFX;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        spriteTransform = transform.GetChild(0); 
        animator = spriteTransform.GetComponent<Animator>();
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

                Vector3 newScale = spriteTransform.localScale;

                if (moveInput.x > 0)
                    newScale.x = -Mathf.Abs(newScale.x); // Face right
                else
                    newScale.x = Mathf.Abs(newScale.x);  // Face left

                spriteTransform.localScale = newScale;
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
            walkingSFX.Stop();
        }
    }

    public void Move(InputAction.CallbackContext context)
    {
        if (!enabled) return;
        walkingSFX.Play();
        moveInput = context.ReadValue<Vector2>();
    }
}