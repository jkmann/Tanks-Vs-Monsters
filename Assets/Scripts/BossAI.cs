using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAI : MonoBehaviour {

	public Transform target;
	UnityEngine.AI.NavMeshAgent enemyAgent;
	public static int health = 25;

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
	public static int getHealth(){
		return health;
	}
}
