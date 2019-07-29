using UnityEngine;
using System.Collections;

public class headBehaviour : MonoBehaviour {


	public float timer = 1.0f;
	public int hp = 5;
	public bool detached = false;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {



	}




	void OnCollisionEnter2D(Collision2D col) // the comments are froma  failed timer project
	{
		if (col.gameObject.tag == "Walls") {

			//timer -= Time.deltaTime;

			hp--;

		}

		//if (timer == 0) {

		if (hp == 0) {

			Destroy (GetComponent<HingeJoint2D>());
			transform.parent = null;
			this.GetComponent<Rigidbody2D>().gravityScale = 1;

			detached = true;

		}

		//timer = 1.0f;


	}








}

