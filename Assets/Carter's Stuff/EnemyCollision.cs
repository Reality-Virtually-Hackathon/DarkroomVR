using UnityEngine;

public class EnemyCollision : MonoBehaviour {

    Player player;

    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent <Player> ();

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy" && this.gameObject.tag == "Player") {
            player.TakeDamage(10);
            other.gameObject.SetActive(false);
        }

    }
}
