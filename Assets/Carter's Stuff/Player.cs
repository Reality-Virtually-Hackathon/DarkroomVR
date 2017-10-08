using UnityEngine;

public class Player : MonoBehaviour {

	public int maxHealth = 100;
	public int currentHealth { get; private set; }


	public Stat damage;

	void Awake()
	{
        currentHealth = maxHealth;
	}

	public void TakeDamage(int damage)
	{
		currentHealth = currentHealth - damage;

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
