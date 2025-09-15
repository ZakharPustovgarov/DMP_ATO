using UnityEngine;

public class BallisticBullet : Bullet
{
    [SerializeField]
    private float speed = 10f;

    public override void StartShot(int damage)
    {
        base.StartShot(damage);
    }

    protected void Update()
    {
        if (!gameObject.activeInHierarchy) return;

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

}
