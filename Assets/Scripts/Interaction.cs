using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour {

    UnityEngine.AI.NavMeshAgent playerAgent;

    void Start()
    {
        playerAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update () {
        if(Input.GetMouseButtonDown(0))
        {
            WorldInteraction();
        }		
	}

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
                playerAgent.destination = infoInteraction.point;
            }
        }
    }
}
