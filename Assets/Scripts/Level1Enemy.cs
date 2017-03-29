using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Enemy : MonoBehaviour {

	public Transform target;
	UnityEngine.AI.NavMeshAgent enemyAgent;
	//Vector3 destination;
	Vector3 m_initialposition;

	// Use this for initialization
	void Start () {
		enemyAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
		//destination = enemyAgent.destination;
		m_initialposition = transform.position;
		target = GameObject.Find ("Player").transform;

		//target = GameObject.FindGameObjectWithTag ("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		enemyAgent.destination = target.position;
		//Debug.Log (timerText.getTime());

	}

	//void OnCollisionEnter(Collision other){
	//	if (other.gameObject.tag == "Player") {
	//		Debug.Log ("collided with tank");
			//transform.position = m_initialposition;
	//		enemyAgent.transform.position = m_initialposition;

	//	}


//}
}
