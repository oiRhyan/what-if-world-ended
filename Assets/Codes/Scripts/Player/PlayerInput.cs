using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerInput : MonoBehaviour
{
    private struct PlayerInputConstants
    {
        public const string Horziontal = "Horizontal";
        public const string Vertical = "Vertical";
        public const string Jump = "Jump";
    }
   public Vector2 GetMovementInput()
        //Input do Teclado 
    {
        float horizontalInput = Input.GetAxisRaw(PlayerInputConstants.Horziontal);

        // Se o Input do teclado for zero, tentamos ler o input do celular
        if (Mathf.Approximately(horizontalInput,0.0f))
        {
            horizontalInput = CrossPlatformInputManager.GetAxisRaw(PlayerInputConstants.Horziontal);
        }
        return new Vector2(horizontalInput, 0);
    }

    public bool IsJumpButoonDown()
    {
        bool isKeyboardButtonDown = Input.GetKeyDown(KeyCode.Space);
        bool isMobileButtonDown = CrossPlatformInputManager.GetButtonDown(PlayerInputConstants.Jump);
        return isKeyboardButtonDown || isMobileButtonDown;
    }
      public bool IsJumpButtonHeld()
    {
        bool IsKeyboardButtonHeld = Input.GetKey(KeyCode.Space);
        bool IsMobileButtonHeld = CrossPlatformInputManager.GetButton(PlayerInputConstants.Jump);
        return IsKeyboardButtonHeld || IsMobileButtonHeld;
    }

    public bool IsCrouchButtonDown()
   {
        bool isKeyBoardButtonDown = Input.GetKeyDown(KeyCode.S);
        bool isMobileButtonDown = CrossPlatformInputManager.GetAxisRaw(PlayerInputConstants.Vertical) < 0;
        return isKeyBoardButtonDown || isMobileButtonDown;
    }
    public bool IsCrouchButtonUp()
    {
        bool isKeyboardButtonUp = Input.GetKey(KeyCode.S) == false;
        bool isMobileButtonUp = CrossPlatformInputManager.GetAxisRaw(PlayerInputConstants.Vertical) >= 0;
        return isKeyboardButtonUp && isMobileButtonUp;
    }

}
