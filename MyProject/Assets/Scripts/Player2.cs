using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player2 : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Player2InputActions player2InputActions;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    private void FixedUpdate2()
    {
        Vector2 input2Vector = GameInput2.Instanse.GetMovementVector2();
        input2Vector = input2Vector.normalized;
        rb.MovePosition(rb.position + input2Vector * (moveSpeed * Time.fixedDeltaTime));

    }
}