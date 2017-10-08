using UnityEngine;

public class EnemySpawning : MonoBehaviour {

    public GameObject enemy;
    GameObject floor;
    Mesh planeMesh;
    Bounds bounds;
    Vector3 randomPointOnPlane;
    public float startTime = 0;
    public float spawnTime = 4;



    void Start() {
        floor = GameObject.FindWithTag("Floor");
		planeMesh = floor.GetComponent<MeshFilter>().mesh;
        bounds = planeMesh.bounds;
        enemy.transform.position = new Vector3(10,10,10);
        Spawn ();
        InvokeRepeating("Spawn", startTime, spawnTime);
	}

       



    //spawn an enemy at a random location 
    void Spawn () {
        float randomX = Random.Range(floor.transform.position.x - (floor.transform.localScale.x / 2) * bounds.size.x, 
                                     floor.transform.position.x + (floor.transform.localScale.x / 2) * bounds.size.x); 
        float randomY = Random.Range(floor.transform.position.y, floor.transform.position.y + 2);
        float randomZ = Random.Range(floor.transform.position.z - (floor.transform.localScale.z / 2) * bounds.size.z,
									 floor.transform.position.z + (floor.transform.localScale.z / 2) * bounds.size.z);
		randomPointOnPlane =  new Vector3(randomX, randomY, randomZ);
        Instantiate(enemy, randomPointOnPlane, Quaternion.identity);
    }


 
}
