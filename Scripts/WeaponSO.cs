using UnityEngine;
using StarterAssets;
using Cinemachine;

[CreateAssetMenu(fileName = "WeaponSO", menuName =  "Scriptable Objects/WeaspomSO")]
public class WeaponSO : ScriptableObject
{
    public GameObject weaponPrefab;
    public int Damage = 1; 
    public float FireRate = .5f; 
    public GameObject HitVFXPrefab;
    public bool IsAutomatic = false; 
    public bool CanZoom = false;
    public float ZoomAmount = 10f;
    public int MagazineSize = 12;
}
