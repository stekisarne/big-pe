using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour {

    public int playerHealth = 100;

    public bool isAlive;

    public playerMovement pm;
    
    // Use this for initialization
	void Start ()
    {

	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemies")
        {
            playerHealth -= 10;
            Debug.Log(playerHealth);
        }
        if (playerHealth <= 0)
        {
            Debug.Log("Game Over");
            isAlive = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
	}
}
