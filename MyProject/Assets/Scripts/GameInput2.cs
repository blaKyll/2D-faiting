using UnityEngine;

public class GameInput2 : MonoBehaviour
{
    public static GameInput2 Instanse { get; private set; }
    private Player2InputActions player2InputActions;
    private void Awake()
    {
        Instanse = this;
        player2InputActions = new Player2InputActions();
        player2InputActions.Enable();
    }
    public Vector2 GetMovementVector2()
    {
        Vector2 inputVector2 = player2InputActions.Player2.Move.ReadValue<Vector2>();
        return inputVector2;
    }
}