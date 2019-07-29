using UnityEngine;
using System.Collections;

public class limbBehaviour : MonoBehaviour {


	public float timer = 1.0f;
	public int hp = 3;
	public bool detached = false;
	public AudioClip sound;
	public int volume;

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
				AudioSource.PlayClipAtPoint(sound, transform.position,volume);

			}

			//timer = 1.0f;


			}








		}
	
