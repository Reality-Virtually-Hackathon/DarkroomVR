using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour {

    Player player = new Player();
    Enemy enemy = new Enemy();

    public void OnCollisionEnter(Collision other)
    {
        print("Collision occured"); 
        if (other.gameObject.tag == "Enemy") {
            player.TakeDamage(10);
            enemy.Die();
        }
    }
}
