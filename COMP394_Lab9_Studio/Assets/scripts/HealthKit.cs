using UnityEngine;

public class HealthKit : MonoBehaviour
{
    [SerializeField] private int healAmount = 10;

    private void OnTriggerEnter(Collider other) //player healed when item stepped on
    {
        PlayerPickupCounter playerHealth = other.GetComponent<PlayerPickupCounter>();

        if (playerHealth != null)
        {
            Debug.Log("Healed 10");

            playerHealth.Heal(healAmount);
            Destroy(gameObject); //one time use
        }
    }
}