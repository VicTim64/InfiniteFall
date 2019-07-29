using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killParticles : MonoBehaviour {

	public float timer = 3.0f;

	// Use this for initialization
	void Start () {
		

		
	}
	
	// Update is called once per frame
	void Update () {
		
		timer = timer - Time.deltaTime;

		if (timer < 0.0f) {

			Destroy (this.gameObject);
		}
			
		
	}
}
