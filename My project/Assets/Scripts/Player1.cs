using UnityEngine;

public class Player1 : MonoBehaviour
{
    public float moveSpeed = 5f;
    private bool isBlocking = false;

    void Update()
    {
        Vector2 move = Vector2.zero;

        // ��������
        if (Input.GetKey(KeyCode.A))
        {
            move = Vector2.left;
            Debug.Log("Player1 moving left");
        }
        if (Input.GetKey(KeyCode.D))
        {
            move = Vector2.right;
            Debug.Log("Player1 moving right");
        }

        // ����
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Player1 attack (LMB)");
            Attack();
        }

        // ����
        isBlocking = Input.GetMouseButton(1);
        if (isBlocking)
        {
            Debug.Log("Player1 is blocking (RMB)");
        }

        // ��������
        transform.Translate(move * moveSpeed * Time.deltaTime);
    }

    void Attack()
    {
        Debug.Log("Player1 attacked!");
    }
}
