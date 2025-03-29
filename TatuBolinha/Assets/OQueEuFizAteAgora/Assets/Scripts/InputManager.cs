using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    
    public static PlayerInput PlayerInput;

    public static Vector2 Movement;
    public static bool jumpPressed;
    public static bool jumpHeld;
    public static bool jumpReleased;
    public static bool runHeld;

    private InputAction moveAction;
    private InputAction jumpAction;
    private InputAction runAction;

    void Awake()
    {
        PlayerInput = GetComponent<PlayerInput>();

        moveAction = PlayerInput.actions["Move2D"];
        jumpAction = PlayerInput.actions["Jump"];
        runAction = PlayerInput.actions["Run"];

    }
    void Update()
    {
        Movement = moveAction.ReadValue<Vector2>();

        jumpPressed = jumpAction.WasPressedThisFrame();
        jumpHeld = jumpAction.IsPressed();
        jumpReleased = jumpAction.WasReleasedThisFrame();

        runHeld = runAction.IsPressed();
    }
}
