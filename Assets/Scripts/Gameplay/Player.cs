using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField]
    private PlayerInput playerInput;
    [SerializeField]
    private Movement movement;
    [SerializeField]
    private Arsenal arsenal;

    void Start()
    {
        DisableProjectWideInput();
    }

    void OnMove(InputValue value)
    {
        Vector2 bufVec = value.Get<Vector2>();

        movement.ChangeMoveDirection(new Vector3(bufVec.x, 0, bufVec.y));
    }

    void OnMouseWheelScroll(InputValue value)
    {
        float direction = value.Get<Vector2>().y;

        if (direction > 0) arsenal.ChangeWeapon(true);
        else if (direction < 0) arsenal.ChangeWeapon(false);
    }

    void DisableProjectWideInput()
    {
        InputSystem.actions.Disable();
        playerInput.currentActionMap?.Enable();
    }
}
