using UnityEngine;
using System.Collections;

public class limbPickupCode : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {

        // This code allows the limbs to pickup coins and powerups as well as the main body that has PC.cs script attached to it

        GameObject NonRPlayer = GameObject.Find("NonRagPlayer");
        PC scoreCount = NonRPlayer.GetComponent<PC>();


        if (col.gameObject.tag == "PickUp")
        {
            scoreCount.scoreCount = scoreCount.scoreCount + 10;
            Debug.Log("Count Log " + scoreCount);

        }

        //Liams Pickup Code Starts
        if (col.gameObject.tag == "PowerUp1")
        {

            scoreCount.powerUpState = 1;
        }
        //Liams Pickup Code Ends
    }
}
