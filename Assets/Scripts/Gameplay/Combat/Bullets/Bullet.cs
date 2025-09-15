using UnityEngine;

public class Bullet : MonoBehaviour
{
    private int damage;

    public virtual void StartShot(int damage)
    {
        this.damage = damage;
    }

    protected void OnCollisionEnter(Collision collision)
    {
        HandleCollision(collision.gameObject);
    }

    protected virtual void HandleCollision(GameObject hitObject)
    {
        
        //Enemy enemy = hitObject.GetComponent<Enemy>();
        //if (enemy != null)
        //{
        //    enemy.TakeDamage(damage);
        //}

        //// Создаем эффект попадания
        //Instantiate(hitEffect, transform.position, transform.rotation);

        gameObject.SetActive(false);
    }
}
