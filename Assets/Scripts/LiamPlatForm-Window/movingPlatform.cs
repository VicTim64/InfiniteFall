using UnityEngine;
using System.Collections;

public class movingPlatform : MonoBehaviour {

	public float moveSpeed;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {

		if (GameObject.Find ("Head").transform.position.x > this.transform.position.x) 
		{
			transform.Translate (new Vector3 (1, 0, 0) * Time.deltaTime * moveSpeed);
		} 



		else if (GameObject.Find ("Head").transform.position.x <= this.transform.position.x) 
		{
			transform.Translate (new Vector3 (-1, 0, 0) * Time.deltaTime * moveSpeed);
		}
	
	}
}
