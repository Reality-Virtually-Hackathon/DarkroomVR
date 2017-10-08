using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public int maxHealth = 100;
	public int currentHealth { get; private set; }


	public Stat damage;

	void Awake()
	{
		maxHealth = currentHealth;
	}

	public void TakeDamage(int damage)
	{
		currentHealth -= damage;
		Debug.Log("Player takes " + damage + " damage.");
        Debug.Log("Player has " + currentHealth + " health");

		if (currentHealth <= 0)
		{
			Die();
		}
	}

	public void Die()
	{
		//code here would need to change the scene to some kind of game over screen
		Debug.Log("GAME OVER");
	}
}
