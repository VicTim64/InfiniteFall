using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {
    public GameObject object1;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D col) //a Unity function that trigers whener a trigger is entered inside unity collider2d
    {
		if (col.gameObject.tag == "Player") //This destroys the game object, in this case our coin if it touches our player
        {
            Destroy(object1.gameObject);
        }
    }
}
