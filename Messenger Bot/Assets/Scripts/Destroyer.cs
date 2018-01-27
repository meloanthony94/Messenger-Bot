using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {

    public ObstacleSpawner spawner;

	// Use this for initialization
	void Start () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obstacles")
        {
            other.gameObject.SetActive(false);
            spawner.ObjectsPool.Add(other.gameObject);
        }
    }
}
