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
	public AudioClip victory;
	public AudioClip loss;
	// Use this for initialization
	void Start () {
		hasEnded = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (BossAI.getHealth () <= 0 && hasEnded == false) {
			//winOrLose.text = "You   Win!";
			print("you win!");
			result = won;
			timeOfEvent = timerText.getTime ();
			AudioSource.PlayClipAtPoint (victory, Camera.main.transform.position);
			hasEnded = true;
		} else if (Health.getHealth() <= 0 && hasEnded == false){
			//winOrLose.text = "You   Lose!";
			timeOfEvent = timerText.getTime ();
			AudioSource.PlayClipAtPoint (loss, Camera.main.transform.position);
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
		BossAI.setHealth (15);
	}
}
