using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    private PlayerInputActions input;

    private void Awake()
    {
        input = new PlayerInputActions();
    }

    private void OnEnable()
    {
        input.Player.Enable();
        input.Player.Attack.performed += OnAttack;
    }

    private void OnDisable()
    {
        input.Player.Attack.performed -= OnAttack;
        input.Player.Disable();
    }

    private void OnAttack(InputAction.CallbackContext ctx)
    {
        Debug.Log("Attack!!");
    }
}