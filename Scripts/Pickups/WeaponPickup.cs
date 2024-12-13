// Made By Brian
using UnityEngine;

public class WeaponPickup : Pickup
{
    [SerializeField] WeaponSO weaponSO;
    protected override void OnPickup(ActiveWeapon activeweapon)
    {
        activeweapon.SwitchWeapon(weaponSO);
    }
}
