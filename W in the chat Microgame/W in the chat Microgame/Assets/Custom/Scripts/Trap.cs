using UnityEngine;
using TMPro;

public class Trap : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public TMP_Text DamageText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DamageText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            playerHealth.health -= 10;
            DamageText.text = "Trap Activated!";
        }
    }
}
