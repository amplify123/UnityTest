using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class CoffeeMeter : MonoBehaviour
{


    public int startingHealth = 100;
    public int currentHealth;
    public int startingArmor = 100;
    public int currentArmor;
    private bool isHit;
  
   



    private void Start()
    {
        
    }

     void Update()
    {
        
        currentHealth = startingHealth;
        currentArmor = startingArmor;

    }
    
    public void TakeDamage(int amount)
    {
        currentHealth -= amount ;

        

            if (currentHealth <= 0)
            {
                currentHealth = 0;
                Destroy(gameObject, 5);
                
            }
        
    }
    
}