using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHover : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void onHover(){
		//GetComponent<Renderer> ().material.color = Color.yellow;
		GetComponent<Font> ().material.color = Color.yellow;
	}

	public void onExit() {
		GetComponent<Font>().material.color = Color.white;	
	}
}
