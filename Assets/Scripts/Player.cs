using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField]
    private Movement movement;

    private InputAction moveAction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per framea
    void Update()
    {
        Vector2 bufVec = moveAction.ReadValue<Vector2>();

        movement.Move(new Vector3(bufVec.x, 0, bufVec.y));
    }
}
