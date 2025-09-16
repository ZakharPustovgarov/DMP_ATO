using UnityEngine;

public class Enemy : Character
{
    [SerializeField]
    protected Movement movement;
    [SerializeField]
    protected float rotationMultiplier = 20f;
    [SerializeField]
    protected Character target;

    protected void Start()
    {
        movement.ChangeMoveDirection(Vector3.forward, Space.Self);
    }

    protected void Update()
    {
        RotateToTarget();
    }

    protected void RotateToTarget()
    {
        Vector3 direction = (target.transform.position - transform.position).normalized;
        Quaternion targetRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationMultiplier * Time.deltaTime);
    }
}
