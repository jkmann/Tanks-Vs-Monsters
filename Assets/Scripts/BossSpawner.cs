using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawner : MonoBehaviour {

	public Transform spawnLocation;
	bool hasSpawned;
	public GameObject prefab;
	public GameObject clone;
	//public AudioClip bossMusic;
	// Use this for initialization
	void Start () {
		hasSpawned = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (timerText.getTime() <= 0 && hasSpawned == false){
			clone = Instantiate(prefab, spawnLocation.transform.position, Quaternion.Euler(0,0,0))as GameObject;
			//AudioSource.PlayClipAtPoint (bossMusic, Camera.main.transform.position);
			hasSpawned = true;
	}

}
}
