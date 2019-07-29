using UnityEngine;
using System.Collections;

//Some Comments are the old code from lesson

public class BGScroller : MonoBehaviour {
    //public float scrollSpeed = 3;
    //private Vector3 startPosition;
    //private float tileWidth = 0;
    // Use this for initialization]

    public float backgroundImageSize;

    private Transform cameraTransform;
    private Transform[] layers;
    private float viewZone = 4;
    private int topIndex;
    private int bottomIndex;

	void Start () {
        //startPosition = transform.position;
        //tileWidth = GetComponent<SpriteRenderer>().sprite.rect.height / 100f;

        cameraTransform = Camera.main.transform; //Assinged position of our camera
        layers = new Transform[transform.childCount]; //This counts the children in an object
        for(int i = 0; i < transform.childCount; i++)
            layers[i] = transform.GetChild(i);  //Loops so long as i is less than total object children, assigns layers a new transform each iteration

        bottomIndex = 0;
        topIndex = layers.Length - 1; //Sets to last layer
	}

	// Update is called once per frame
	void Update () {
        //float offsetPosition = Mathf.Repeat(Time.time * scrollSpeed, tileWidth);
        //transform.position = startPosition + new Vector3(0,1,0) * offsetPosition;
        //transform.Translate(new Vector3(-1,0,0) * Time.deltaTime * scrollSpeed);

        /*
        if (Input.GetKey(KeyCode.W))
            ScrollUp();
        if (Input.GetKey(KeyCode.S))
            ScrollDown();
        */   //Manual update position with this

        if (cameraTransform.position.y < (layers[topIndex].transform.position.y - viewZone))
            ScrollDown();
        if (cameraTransform.position.y > (layers[bottomIndex].transform.position.y + viewZone))
            ScrollUp();
              //Auto update position with this
    }

    void ScrollDown()
    {
        int lastTop = topIndex;         //Stores the value of our initial topIndex for later use
        layers[topIndex].position = Vector3.up * (layers[bottomIndex].position.y - backgroundImageSize);  //Assigned Vector3 values to Layers array based on top/bottom index and backgroundsize
        bottomIndex = topIndex; //Bottom Index takes value of TOp Index
        topIndex--;  //deiterate topindex
        if(topIndex < 0)
            topIndex = layers.Length - 1; //Error checking
        



    }

    void ScrollUp()
    {

        int lastBottom = bottomIndex;         //Stores the value of our initial topIndex for later use
        layers[bottomIndex].position = Vector3.up * (layers[topIndex].position.y + backgroundImageSize);  //Assigned Vector3 values to Layers array based on top/bottom index and backgroundsize
        topIndex = bottomIndex; //Bottom Index takes value of TOp Index
        bottomIndex++;  //deiterate topindex
        if(bottomIndex == layers.Length)
            bottomIndex = 0; //Error checking
        

    }
}
