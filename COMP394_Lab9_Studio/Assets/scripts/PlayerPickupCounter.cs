using UnityEngine;



public class PlayerPickupCounter : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] private int maxHealth = 100;
    [SerializeField] private int health = 50;

    [Header("Gems")]
    [SerializeField] private int gemNumber;
    [SerializeField] private Timer gameManager;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Player starts not at full health so healthkits can be used

    }

    // Update is called once per frame
    void Update()
    {

    }


    //Health pickup ==========================
    public void Heal(int amount)
    {

        health += amount;
        health = Mathf.Clamp(health, 0, maxHealth);
        Debug.Log("Player Healed: " + amount);
        Debug.Log("Current Health: " + health);


    }


    //Gem pickup ==============

    public void GemCollection(int gemCount)
    {
        gemNumber += gemCount;
        gameManager.AddGems(gemCount);

        Debug.Log("Gem Added: " + gemCount);
        Debug.Log("Current Gem Number: " + gemNumber);
    }

}