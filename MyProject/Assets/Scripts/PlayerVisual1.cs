using UnityEngine;

public class PlayerVisual1 : MonoBehaviour
{
    private Animator animator;
    private const string IS_RUNNING= "IsRunning";
    private const string IS_ATTACK = "IsAttack";
    private void Awake()
    {
        animator= GetComponent<Animator>();
    }
    private void Update()
    {
        animator.SetBool(IS_RUNNING, Player1.Instance.IsRunning());
        animator.SetBool(IS_ATTACK, Player1.Instance.IsAttack());
    }
}
