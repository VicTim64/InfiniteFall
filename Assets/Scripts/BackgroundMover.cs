using UnityEngine;
using System.Collections;

public class BackgroundMover : MonoBehaviour {

    private Vector3 offset = new Vector3(0, -2.5f, 1.47f);
    public Transform lookAt;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = lookAt.transform.position + offset;
		if (GameObject.Find ("NonRagPlayer").GetComponent<PC> ().up == true) {

			offset = new Vector3 (0, 2.5f, 1.47f);
		}
	}
}
