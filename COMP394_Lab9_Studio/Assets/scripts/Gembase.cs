using UnityEngine;


public class GemBase : MonoBehaviour
{
    [SerializeField] private GameObject gem;
    [SerializeField] private int gemAmount = 1;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {

        PlayerPickupCounter playerGemCount = other.GetComponent<PlayerPickupCounter>();

        if (other.CompareTag("Player"))
        {
            Debug.Log("Gem Picked up");

            playerGemCount.GemCollection(gemAmount);
            Destroy(gameObject);
        }

    }
}