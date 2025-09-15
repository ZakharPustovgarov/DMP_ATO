using UnityEngine;

public class Arsenal : MonoBehaviour
{
    [SerializeField]
    private Weapon[] weapons;

    [SerializeField]
    private int currentWeaponId = 0;

    void Start()
    {
        ActivateWeapon(0);
    }

    public void ShootCurrentWeapon()
    {
        weapons[currentWeaponId].Shoot();
    }

    public void ChangeWeapon(int weaponId)
    {
        if (weaponId >= weapons.Length || weaponId < 0) return;

        DeactivateWeapon(currentWeaponId);
        currentWeaponId = weaponId;
        ActivateWeapon(currentWeaponId);
    }

    public void ChangeWeapon(bool isScrollUp)
    {
        DeactivateWeapon(currentWeaponId);
        currentWeaponId = getIdByScroll(isScrollUp);
        ActivateWeapon(currentWeaponId);
    }

    void ActivateWeapon(int weaponId)
    {
        weapons[weaponId].gameObject.SetActive(true);
    }

    void DeactivateWeapon(int weaponId)
    {
        weapons[weaponId].gameObject.SetActive(false);
    }

    int getIdByScroll(bool isScrollUp)
    {
        switch(isScrollUp)
        {
            case false:
                if (currentWeaponId - 1 < 0) return weapons.Length - 1;
                else return currentWeaponId - 1;
            case true:
                if (currentWeaponId + 1 == weapons.Length) return 0;
                else return currentWeaponId + 1;
        }        
            
    }
}
