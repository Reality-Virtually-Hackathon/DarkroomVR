using UnityEngine;

public class Enemy : MonoBehaviour
{

    public GameObject player;
	public float speed;
	
    void Update()
	{
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, player.transform.position, step);
	}

    public void Die () {
        Destroy(this);
    }
}
