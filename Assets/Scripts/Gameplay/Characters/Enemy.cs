using UnityEngine;

public class Enemy : Character
{
    [SerializeField]
    protected Movement movement;
    [SerializeField]
    protected float rotationMultiplier = 20f;
    [SerializeField]
    protected Character target;
    [SerializeField]
    protected int damage = 1;

    protected override void Start()
    {
        base.Start();
        movement.ChangeMoveDirection(Vector3.forward, Space.Self);
    }

    protected void Update()
    {
        RotateToTarget();
    }

    protected void RotateToTarget()
    {
        Vector3 targetPosition = target.transform.position;
        targetPosition.y = transform.position.y;

        Vector3 direction = (targetPosition - transform.position).normalized;

        Quaternion targetRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationMultiplier * Time.deltaTime);
    }

    protected void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Entered collsion with " + collision.gameObject.name);
        Player player = collision.gameObject.GetComponent<Player>();
        if (player != null)
        {
            player.TakeDamage(damage);
        }
    }
}
