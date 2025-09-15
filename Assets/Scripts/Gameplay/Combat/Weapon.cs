using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField]
    protected float shootCooldown = 1f;

    protected bool isCooldown = false;


    public virtual void Shoot()
    {
        if (!CheckShootRestrictions()) return;

    }

    protected virtual bool CheckShootRestrictions()
    {
        if (isCooldown) return false;

        return true;
    }
}
