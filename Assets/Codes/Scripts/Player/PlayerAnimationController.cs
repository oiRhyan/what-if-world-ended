using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Platformer2D.Character;

public static class CharacterMovementAnimationKeys
{
    public const string IsCrounching = "IsCrounching";
    public const string HorizontalSpeed = "HorizontalSpeed";
    public const string VerticalSpeed = "VerticalSpeed";
    public const string IsGrounded = "IsGrounded";
}
public class PlayerAnimationController : MonoBehaviour
{
    Animator animator;
    CharacterMovement2D playerMovement;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        playerMovement = GetComponent<CharacterMovement2D>();
    }

    private void Update()
    {
        animator.SetBool(CharacterMovementAnimationKeys.IsCrounching, playerMovement.IsCrouching);
        animator.SetFloat(CharacterMovementAnimationKeys.HorizontalSpeed, playerMovement.CurrentVelocity.x / playerMovement.MaxGroundSpeed);
        animator.SetFloat(CharacterMovementAnimationKeys.VerticalSpeed, playerMovement.CurrentVelocity.y / playerMovement.JumpSpeed);
        animator.SetBool(CharacterMovementAnimationKeys.IsGrounded, playerMovement.IsGrounded);
    }
}