using UnityEngine;
using System.Collections;

public class DestroyObject : MonoBehaviour {
    public GameObject object1; //Define a public gameobject called object1, we set it inside of unity

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "NonRagPlayer") //This basically destroys the object we set in Unity as our public var if it touches player
        {
            Destroy(object1.gameObject);
        }
    }
    
}
