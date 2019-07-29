using UnityEngine;
using System.Collections;

public class destroyWindow : MonoBehaviour {
	public GameObject object1;
	public GameObject remains;
	public float timer = 5.0f;
	public AudioClip sound;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if (timer == 0.0f) {

			Destroy (remains.gameObject);
		}

	}

	void OnCollisionEnter2D (Collision2D col)
	{


		if (col.gameObject.name == "NonRagPlayer") {
			timer = timer - Time.deltaTime;
			Destroy (this.gameObject);
			Instantiate (remains, transform.position + transform.forward * -0.1f + transform.right * 2.0f + transform.up * -2.5f, transform.rotation);
			AudioSource.PlayClipAtPoint (sound, transform.position);


		}

	}
}
