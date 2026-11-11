using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerManaAttack : MonoBehaviour
{
    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ManaAttack();
    }

    void ManaAttack()
    {
        if (Keyboard.current.rKey.wasPressedThisFrame)
        {
            PlayerMana mana = GetComponent<PlayerMana>();

            if (mana.mana - 10 >= 0)
            {
                mana.mana -= 10;
                animator.SetBool("ManaAttack", true);
                
            }
            
        }
        else
        {
            animator.SetBool("ManaAttack", false);
        }
    }
}
