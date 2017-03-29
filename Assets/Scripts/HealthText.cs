using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthText : MonoBehaviour {
	public static int current_health;
	Text text;
	int total = 100;

	// Use this for initialization

	void Start () {
		text = GetComponent <Text> ();
		current_health = 100;
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "HEALTH: " + current_health + "/" + total;
	}
}
