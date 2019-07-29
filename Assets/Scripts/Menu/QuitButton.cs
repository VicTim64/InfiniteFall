using UnityEngine;
using System.Collections;

public class QuitButton : MonoBehaviour {

	// Use this for initialization
	public void onClick () {

        
        Application.Quit();
        Debug.Log("Quit Game");

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}