using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lv1Spawner : MonoBehaviour {

	public Transform[] spawnLocations;
	public GameObject[] prefab;
	public GameObject[] clones;
	public bool isWave = true;
	public bool isBoss = true;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("spawnMonster", 5.0f, 3.0f);
	}
	
	// Update is called once per frame
	void Update () {
		//InvokeRepeating ("spawnMonster", 5.0f, 3.0f);
		if (timerText.getTime () < 90) {
			CancelInvoke ();
		}
		if (timerText.getTime () < 45 && isWave == true) {
			InvokeRepeating ("spawnMonster", 5.0f, 3.0f);
			isWave = false;
		}
		if (timerText.getTime () < 10 && isBoss == true) {
			CancelInvoke ();
			isBoss = false;
		}
			
	}

	void spawnMonster(){
		Debug.Log ("spawning enemy");
		int Index = Random.Range (0, prefab.Length);
		int spawn = Random.Range (0, spawnLocations.Length);
		clones[Index] = Instantiate(prefab[Index], spawnLocations[spawn].transform.position, Quaternion.Euler(0,0,0))as GameObject;
	}

	}

