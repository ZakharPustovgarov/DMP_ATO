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

    protected virtual void OnDeath()
    {
        gameObject.SetActive(false);
    }
}
