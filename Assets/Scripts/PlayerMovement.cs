using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Animator Animator;
    private Vector2 moveDirection;
    public Rigidbody2D Rigidbody2D;
    public void OnMove(InputValue value)
    {
        moveDirection = value.Get<Vector2>();
        print(moveDirection.x + "," +moveDirection.y);
    }

    public void FixedUpdate()
    {
        //animate
        FaceCorrectDirection();
        //move
        Animate();
        //face right direction
        Move();
    }

    public void Animate()
    {
        Animator.SetFloat("horizontal", Mathf.Abs( moveDirection.x));
        Animator.SetFloat("vertical", Mathf.Abs(moveDirection.y));
    }
    public void Move()
    {
        Rigidbody2D.linearVelocity = moveDirection * GameParameters.PlayerSpeed;
    }

    public void FaceCorrectDirection()
    {
        
    }
}
