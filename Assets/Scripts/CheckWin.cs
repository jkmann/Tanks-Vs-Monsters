using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CheckWin : MonoBehaviour {

	public Text winOrLose;
	public float timeOfEvent;
	public bool hasEnded = false;
	public string won = "You   Win!";
	public string lost = "You   Lose!";
	public string result;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (BossAI.getHealth () <= 0 && hasEnded == false) {
			//winOrLose.text = "You   Win!";
			result = won;
			timeOfEvent = timerText.getTime ();
			hasEnded = true;
		} else if (Health.getHealth() <= 0 && hasEnded == false){
			//winOrLose.text = "You   Lose!";
			timeOfEvent = timerText.getTime ();
			result = lost;
			hasEnded = true;
		}	else if (hasEnded == false) {
			winOrLose.text = " ";
		}
		if (hasEnded == true) {
			winOrLose.text = result;
			StartCoroutine ("DelayStart");
			print ("loading menu");
		}
}
	private IEnumerator DelayStart()
	{
		yield return new WaitForSeconds(5);
		SceneManager.LoadScene (0);

	}
}
