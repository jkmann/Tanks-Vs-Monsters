using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class timerText : MonoBehaviour
{

	public Text time;
	public Text objective;
	//private float start_Time;
	private static float current_Time;
	//private string text_Time;
	// Use this for initialization
	void Start ()
	{
		//start_Time = Time.time;
		current_Time = 10;

	}
	
	// Update is called once per frame
	void Update ()
	{current_Time -= Time.deltaTime;
		string minutes = ((int)current_Time / 60).ToString();
		string seconds = (current_Time % 60).ToString ("f2");
		time.text = minutes + ":" + seconds;
		
		if (current_Time <= 0) {
			objective.text = "Defeat the boss!";
			time.text = "0:00";
		} else if (current_Time <= 110 && current_Time > 0) {
			objective.text = " ";
		} 
	}

	public static float getTime ()
	{
		return current_Time;
	}
	/*
	public string getText ()
	{
		return this.text_Time;
	}
	*/
}
