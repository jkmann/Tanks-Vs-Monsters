using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public bool isStart;
	public bool isQuit;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseUp(){
		if(isStart)
		{
			SceneManager.LoadScene("Scene 1");
		}
		if (isQuit)
		{
			Application.Quit();
		}
	} 

}
