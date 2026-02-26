using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private CharacterController controller;
    private Vector2 moveInput;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Must match the Action name from your InputSystem_Actions
    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    void Update()
    {
        Vector3 move = new Vector3(moveInput.x, 0, moveInput.y);
        controller.Move(move * speed * Time.deltaTime);
    }
}