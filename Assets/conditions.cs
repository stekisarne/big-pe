using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conditions : MonoBehaviour {

    public int userValue = 2;

    public int diceStartValue = 10;

    public int dragonHealth;

    public int playerHealth;

    public int playerDamage;

    public int dragonDamage;

    public int dragonHitChance;

    public int dragonDouble;

    public int minDamage;

    public int maxDamage;

    public int critChance;
    
    public int lastNumber = 50;

    public int HiLo;

    // Use this for initialization
	void Start ()
    {
        dragonHealth = Random.Range(100, 151);
        dragonDouble = Random.Range(1, 11);
        if (dragonDouble == 10)
        {
            print("Dragon did his special move and is now two times stronger");
            dragonHealth = dragonHealth * 2;
            dragonDamage = dragonDamage * 2;
        }
        minDamage = Random.Range(5, 16);
        maxDamage = Random.Range(20, 35);
    }

    // Update is called once per frame
    void Update()
    {
        //uppgift 1

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            userValue += 2;
            print(userValue);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            userValue /= 2;
            print(userValue);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print(userValue);
        }

        //uppgift 2

        if (Input.GetKeyDown(KeyCode.R))
        {
            diceStartValue = diceStartValue - Random.Range(1, 9);
            diceStartValue = diceStartValue + Random.Range(1, 9);
            print(diceStartValue);

            if (diceStartValue >= 20)
            {
                print("yay you got bröd");
            }

            else if (diceStartValue <= 0)
            {
                print("you fock sock");
            }
        }

        //uppgift3
        if (Input.GetKeyDown(KeyCode.Space))
        {
            critChance = Random.Range(0, 21);
            playerDamage = Random.Range(minDamage, maxDamage);
            dragonHitChance = Random.Range(0, 2);
            dragonHealth = dragonHealth - playerDamage;

            if (critChance == 20)
            {
                playerDamage = playerDamage * 2;
            }
            //drakens tur
            if (dragonHitChance == 1)
            {
                dragonDamage = Random.Range(10, 21);
                playerHealth = playerHealth - dragonDamage;
                print("Dragon did " + dragonDamage + " Damage");
                print("Player HP: " + playerHealth);
            }
            else
            {
                print("Dragon Missed");
            }
            //spelarens tur
            print("player did " + playerDamage + " damage");
            print("Dragon HP: " + dragonHealth);
            if (dragonHealth <= 0)
            {
                print("The dragon is now ded");
            }
            else if (playerHealth <= 0)
            {
                print("You ded");
            }
            if (dragonDouble == 10)
            {
                dragonHealth = dragonHealth * 2;
                dragonDamage = dragonDamage * 2;
            }
        }

        //uppgift 5
        if (Input.GetKeyDown(KeyCode.Y))
        {
            
        }


	}
}
