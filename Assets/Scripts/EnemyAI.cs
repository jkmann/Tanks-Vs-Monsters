using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

	public Transform target;
	UnityEngine.AI.NavMeshAgent enemyAgent;
	Vector3 destination; 

	// Use this for initialization
	void Start () {
		enemyAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
		destination = enemyAgent.destination;
		//target = GameObject.FindGameObjectWithTag ("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		enemyAgent.destination = target.position;
	}


}
