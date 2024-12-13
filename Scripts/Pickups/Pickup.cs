using Unity.VisualScripting;
using UnityEngine;

public abstract class Pickup : MonoBehaviour
{
    [SerializeField] float rotationnSpeed = 100f;
    const string PLAYER_STRING = "Player";
    void Update()
    {
        transform.Rotate(0f, rotationnSpeed * Time.deltaTime, 0f);
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag(PLAYER_STRING))
        {
            ActiveWeapon activeWeapon = other.GetComponentInChildren<ActiveWeapon>();
            OnPickup(activeWeapon);
            Destroy(this.gameObject);
        }

    }
    protected abstract void OnPickup(ActiveWeapon activeweapon);
}
