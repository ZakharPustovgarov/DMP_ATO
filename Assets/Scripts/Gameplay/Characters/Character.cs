using UnityEngine;
using UnityEngine.InputSystem;

public class Character : MonoBehaviour
{
    [SerializeField]
    private Health health;

    protected virtual void Start()
    {
        health.OnDeath += OnDeath;
    }

    public virtual void TakeDamage(int damage)
    {
        Debug.Log(gameObject.name + " took " + damage + " damage");
        health.TakeDamage(damage);
    }

    protected virtual void OnDeath()
    {
        Debug.Log(gameObject.name + " died");
        gameObject.SetActive(false);
    }
}
