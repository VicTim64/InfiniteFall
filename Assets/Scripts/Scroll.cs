using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour {

    public float speed;
	//public Renderer rend;
	// Use this for initialization
	void Start () {
		//rend = GetCompoent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {

		//float offset = Time.deltaTime * speed;
		//GetComponent<Renderer>().material.SetTextureOffset ("_MainTex", new Vector2 (0, offset));

		
		//Here is where the scroll work happens
       Vector2 offset = new Vector2(0, Time.deltaTime * speed);  //We define a new Vector2 called offset at position (0, Time.deltaTime * speed, 0) this makes it change Y position based on time and our speed var
       GetComponent<Renderer>().material.mainTextureOffset += offset; //This gets the Renderer component of the object the script is on and more so it gets the material on the renderer and applies a textureOffset to it based on our offset set ealier
		if (GameObject.Find ("NonRagPlayer").GetComponent<PC> ().up == true) { //This will change the speed var of the player object if it's going up, up is a short hand for (0,1,0).

			speed = 0.2f;
		}
    }
}
