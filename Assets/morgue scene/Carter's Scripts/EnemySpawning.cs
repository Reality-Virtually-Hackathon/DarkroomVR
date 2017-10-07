using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawning : MonoBehaviour {

    GameObject enemy;
    GameObject floor;
    float xMin, xMax, zMin, zMax;

    void Start(){
        enemy = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        floor = GameObject.CreatePrimitive(PrimitiveType.Plane);
        enemy.transform.position = new Vector3(10,10,10);

	}

    // Update is called once per frame
    void Update () {
		
	}
}
