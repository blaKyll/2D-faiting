using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float moveSpeed = 5f;
    private bool isBlocking = false;

    void Update()
    {
        Vector2 move = Vector2.zero;

        // Движение
        if (Input.GetKey(KeyCode.Keypad4))
        {
            move = Vector2.left;
            Debug.Log("Player2 moving left");
        }
        if (Input.GetKey(KeyCode.Keypad6))
        {
            move = Vector2.right;
            Debug.Log("Player2 moving right");
        }

        // Удар
        if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            Debug.Log("Player2 attack (Numpad ↑)");
            Attack();
        }

        // Блок
        isBlocking = Input.GetKey(KeyCode.Keypad5);
        if (isBlocking)
        {
            Debug.Log("Player2 is blocking (Numpad 5)");
        }

        // Движение
        transform.Translate(move * moveSpeed * Time.deltaTime);
    }

    void Attack()
    {
        Debug.Log("Player2 attacked!");
    }
}
