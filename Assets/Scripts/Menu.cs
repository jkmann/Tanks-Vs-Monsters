using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public AudioClip menuMusic;
	// Use this for initialization
	void Start () {
		AudioSource.PlayClipAtPoint (menuMusic, Camera.main.transform.position);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void NewSceneLoader(){
		//Debug.Log ("loading");
		SceneManager.LoadScene("Scene 1");

	} public void quitGame(){
		Application.Quit();
		
	} 
}

