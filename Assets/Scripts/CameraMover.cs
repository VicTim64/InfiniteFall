using UnityEngine;
using System.Collections;

public class CameraMover : MonoBehaviour {

    private Vector3 offset = new Vector3(0, -2.5f, -15.6f); //Define a private var as type Vector3 called offset at the values in the new Vector3
    public Transform lookAt; //Define a public var as type Transform called lookAt

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = lookAt.transform.position + offset; //At the start of each frame the object position will become lookAt's position plus out offset, 
		if (GameObject.Find ("NonRagPlayer").GetComponent<PC> ().up == true) { //Changes our offset each frame if we're going up, up is shorthand for (0,1,0),0

			offset = new Vector3 (0, 2.5f, -15.6f);
		}
	}
}
