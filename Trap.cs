using UnityEngine;

public class Trap : MonoBehaviour
{
    public bool isActive = true;
    public float damage = 10f;

    void Update()
    {
        if (isActive)
        {
            // Trap behavior: falling boulders, spikes rising, etc.
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Handle damage to player if they hit the trap
            other.GetComponent<PlayerHealth>().TakeDamage(damage);
        }
    }
}
