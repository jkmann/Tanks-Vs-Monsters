using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour {

    UnityEngine.AI.NavMeshAgent playerAgent;
	public GameObject bulletPrefab;
	public Transform bulletSpawn;
	public AudioClip fire;
	void Start()
    {
        playerAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();

    }

    // Update is called once per frame
    void Update () {
		
        if(Input.GetMouseButtonDown(0))
        {
			Ray rayInteraction = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit infoInteraction;

			if (Physics.Raycast(rayInteraction, out infoInteraction, Mathf.Infinity))
			{
				GameObject objectInteraction = infoInteraction.collider.gameObject;
				if(objectInteraction.tag == "Enemy" || objectInteraction.tag == "Boss")
				{
					//playerAgent.destination = playerAgent.transform.position;
					Fire ();
				}
				else
				{
					playerAgent.destination = infoInteraction.point;
				}

			}
        }		
	}

	void Fire()
	{
		print ("Fire!");
		// Create the Bullet from the Bullet Prefab
		var bullet = (GameObject)Instantiate(
			bulletPrefab,
			bulletSpawn.position,
			bulletSpawn.rotation);
		AudioSource.PlayClipAtPoint (fire, Camera.main.transform.position);
		// Add velocity to the bullet
		bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 60;

		// Destroy the bullet after 2 seconds
		Destroy(bullet, 3.0f);        
	}


}
