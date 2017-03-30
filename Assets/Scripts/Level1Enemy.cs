using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Enemy : MonoBehaviour {

	public Transform target;
	UnityEngine.AI.NavMeshAgent enemyAgent;
	public int health = 1;

	// Use this for initialization
	void Start () {
		enemyAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
		target = GameObject.Find ("Player").transform;

	
	}
	
	// Update is called once per frame
	void Update () {
		enemyAgent.destination = target.position;


	}

	//void OnCollisionEnter(Collision other){
	//	if (other.gameObject.tag == "Player") {
	//		Debug.Log ("collided with tank");
			//transform.position = m_initialposition;
	//		enemyAgent.transform.position = m_initialposition;

	//	}


//}
}
