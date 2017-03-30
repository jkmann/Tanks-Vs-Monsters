using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawner : MonoBehaviour {

	public Transform spawnLocation;
	bool hasSpawned = true;
	public GameObject prefab;
	public GameObject clone;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (timerText.getTime() <= 0 && hasSpawned == true){
			clone = Instantiate(prefab, spawnLocation.transform.position, Quaternion.Euler(0,0,0))as GameObject;
			hasSpawned = false;
	}
}
}
