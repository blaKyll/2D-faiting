using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player1 : MonoBehaviour
{
    public static Player1 Instance { get; private set; }
    [SerializeField] private float moveSpeed = 5f;
    private Rigidbody2D rb;
    private PlayerInputActions playerInputActions;
    private float minMovingSpeed = 0.1f;
    private bool isRunning = false;
    private void Awake()
    {
        Instance = this;
        rb = GetComponent<Rigidbody2D>();
       
    }
    private void FixedUpdate()
    {
        HandleMovement();

    }
    private void HandleMovement() 
    {
        Vector2 inputVector = GameInput.Instanse.GetMovementVector();
        inputVector = inputVector.normalized;
        rb.MovePosition(rb.position + inputVector * (moveSpeed * Time.fixedDeltaTime));

        if(Mathf.Abs(inputVector.x)>minMovingSpeed || Mathf.Abs(inputVector.y) > minMovingSpeed)
        {
            isRunning = true;

        }
        else
        {
            isRunning=false;
        }

    }
    public bool IsRunning()
    {
        return isRunning;
    }
}
