using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

	public Transform[] waypoints;
	int cur = 0;
	UnityEngine.AI.NavMeshAgent enemyAgent;
	float speed = 5.0f;
	private Vector3 m_initialposition;

	// Use this for initialization
	void Start () {
		m_initialposition = transform.position;
		enemyAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position != waypoints[cur].position) {
			enemyAgent.destination = waypoints[cur].position;
		}
		else cur = (cur + 1) % waypoints.Length;
	}
	/*
	void WorldInteraction()
	{
		Ray rayInteraction = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit infoInteraction;

		if (Physics.Raycast(rayInteraction, out infoInteraction, Mathf.Infinity))
		{
			GameObject objectInteraction = infoInteraction.collider.gameObject;
			if(objectInteraction.tag == "Interactable Object")
			{
				// for objects to interact with
			}
			else
			{
				enemyAgent.destination = waypoints[cur].position;

			}
		}
	}
	*/
}
