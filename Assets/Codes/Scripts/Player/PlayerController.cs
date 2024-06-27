using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Platformer2D.Character;

[RequireComponent(typeof(CharacterMovement2D))]
[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(PlayerInput))]

public class PlayerController : MonoBehaviour
{
    CharacterMovement2D playerMovement;
    SpriteRenderer spriteRenderer;
    PlayerInput playerInput;

     
    // Start is called before the first frame update
    void Start()
    {
        playerMovement = GetComponent<CharacterMovement2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        playerInput = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        //Movimentação do Personagem Man
        Vector2 movementInput = playerInput.GetMovementInput();
        playerMovement.ProcessMovementInput(movementInput);

        if (movementInput.x > 0)
        {
            spriteRenderer.flipX = false;
        }
        else if (movementInput.x < 0)
        {
            spriteRenderer.flipX = true;
        }

        //Pular mano
        if (playerInput.IsJumpButoonDown())
        {
            playerMovement.Jump();
        }

        //Agachar Mano 

        if (playerInput.IsCrouchButtonDown())
        {
            playerMovement.Crouch();

            //Remover quando tiver Animação
           
        }
         else if (playerInput.IsCrouchButtonUp())
        {
            playerMovement.UnCrouch();
          
            //Remover quando tiver Animação
        } 
    }

}
