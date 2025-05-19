using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player2 : MonoBehaviour
{
    public static Player2 Instance { get; private set; }
    [SerializeField] private float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Player2InputActions player2InputActions;
    private bool isRunning2 = false;
    private float minMovingSpeed2 = 0.1f;

    private void Awake()
    {
        Instance = this;
        rb = GetComponent<Rigidbody2D>();

    }
    private void FixedUpdate2()
    {
        HandleMovement();

    }
    private void HandleMovement()
    {
        Vector2 inputVector = GameInput.Instanse.GetMovementVector();
        inputVector = inputVector.normalized;
        rb.MovePosition(rb.position + inputVector * (moveSpeed * Time.fixedDeltaTime));
        if (Mathf.Abs(inputVector.x) > minMovingSpeed2 || Mathf.Abs(inputVector.y) > minMovingSpeed2)
        {
            isRunning2 = true;

        }
        else
        {
            isRunning2 = false;
        }


    }
    public bool IsRunning()
    {
        return isRunning2;
    }
}