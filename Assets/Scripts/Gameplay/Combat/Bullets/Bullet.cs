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
        Debug.Log("Entered collsion with " + collision.gameObject.name);
        Character character = collision.gameObject.GetComponent<Character>();
        if (character != null)
        {
            character.TakeDamage(damage);
        }

        // эффект попадания

        gameObject.SetActive(false);
    }


}
