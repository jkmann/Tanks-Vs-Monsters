using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lv2Spawner : MonoBehaviour {

	public Transform[] spawnLocations;
	public GameObject[] prefab;
	public GameObject[] clones;
	bool timeCheck = true;
	// Use this for initialization
	void Start () {
		//InvokeRepeating ("spawnMonster", 5.0f, 3.0f);
	}

	// Update is called once per frame
	void Update () {
		//InvokeRepeating ("spawnMonster", 5.0f, 3.0f);
		if (timerText.getTime () < 90 && timeCheck == true) {
			InvokeRepeating ("spawnMonster", 5.0f, 2.5f);
			timeCheck = false;
		} else if (timerText.getTime() < 10) {
			CancelInvoke ();
		}
	}
	void spawnMonster(){
		Debug.Log ("spawning enemy");
		int Index = Random.Range (0, prefab.Length);
		int spawn = Random.Range (0, spawnLocations.Length);
		clones[Index] = Instantiate(prefab[Index], spawnLocations[spawn].transform.position, Quaternion.Euler(0,0,0))as GameObject;
	}
}
