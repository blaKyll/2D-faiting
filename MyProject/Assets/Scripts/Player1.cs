using UnityEngine;

public class Player1 : MonoBehaviour
{
    public static Player1 Instance { get; private set; }

    [Header("Movement Settings")]
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float minMovingSpeed = 0.1f;


    private Rigidbody2D rb;
    private bool isRunning = false;
    private bool isAttacking = false;

    private void Awake()
    {

        Instance = this;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        IsAttacking(); // Обработка ввода в Update
    }

    private void FixedUpdate()
    {
        HandleMovement(); // Физика в FixedUpdate
    }

    private void IsAttacking()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("attack");
            isAttacking = true;
        }
        else
        {
            isAttacking = false;
        }
    }

    public bool IsAttack()
    {
        return isAttacking;
    }

    private void HandleMovement()
    {
        Vector2 inputVector = GameInput.Instanse.GetMovementVector();
        inputVector = inputVector.normalized;
        rb.MovePosition(rb.position + inputVector * (moveSpeed * Time.fixedDeltaTime));

        isRunning = (Mathf.Abs(inputVector.x) > minMovingSpeed ||
                    (Mathf.Abs(inputVector.y) > minMovingSpeed));
    }

    public bool IsRunning()
    {
        return isRunning;
    }
}