using UnityEngine;
using System.Collections;

public class BGScrollerV2 : MonoBehaviour {

    //Alternate method, this one interferes with our triggers for the coin and walls, fixing V1 is the ideal solution.

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerExit2D(Collider2D collider)
    {
        float height = ((BoxCollider2D)collider).size.y;

        Vector3 pos = collider.transform.position;
        pos.y += height * -1.196f;
            
        
        if (collider.gameObject.tag == "BG1")
        {
            collider.transform.position = pos;
        }
        if (collider.gameObject.tag == "BG2")
        {
            collider.transform.position = pos;
        }
    }
}
