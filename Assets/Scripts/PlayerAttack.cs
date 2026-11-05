using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    public Animator Animator;

    public void OnAttack(InputValue value)
    {
        Animator.SetBool("IsAttacking", true);
    }

    public void FinishingAttacking()
    {
        Animator.SetBool("IsAttacking", false);
    }
}
