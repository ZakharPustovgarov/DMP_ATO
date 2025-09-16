using UnityEngine;
using UnityEngine.InputSystem;

public class Player : Character
{
    [SerializeField]
    private PlayerInput playerInput;
    [SerializeField]
    private Movement movement;
    [SerializeField]
    private Arsenal arsenal;

    private bool isShooting = false;

    protected override void Start()
    {
        base.Start();
        DisableProjectWideInput();
    }

    private void Update()
    {
        if(isShooting)
        {
            arsenal.ShootCurrentWeapon();
        }
    }

    void OnMove(InputValue value)
    {
        Vector2 bufVec = value.Get<Vector2>();

        movement.ChangeMoveDirection(new Vector3(bufVec.x, 0, bufVec.y));
    }

    void OnAttackPressed(InputValue value)
    {
        float isPressed = value.Get<float>();

        if (isPressed > 0) isShooting = true;
        else isShooting = false;
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
