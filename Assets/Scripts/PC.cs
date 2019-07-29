using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PC : MonoBehaviour
{
    private float moveSpeed = 15;
	public bool win = false;
	private bool loseCond = false; //This is redundant now??
    private bool dropCollision = false;
    private bool boundaryCollisionL = false;
    private bool boundaryCollisionR = false;
    public int scoreCount = 0;
	public bool newBoolC = false;
	public bool newBoolC2;
	public bool up;
	public int level;

    //Liams Vars
    public int powerUpState = 0;
    public float dropSpeed = 1.0f;
    private bool lose = false;
    public float powerUp1Speed = 0.5f;

    // Use this for initialization
    void Start()
    {

        Time.timeScale = 1;
        //GameObject Quad = GameObject.Find("Quad");
        //Scroll scroll = Quad.GetComponent<Scroll>();
        //scroll.speed = 0;  This is for reference later when grabbing from files
    }

    // Update is called once per frame
    void Update()
    {
		GameObject PauseImageChange = GameObject.Find ("PauseImageChangerObject");
		ImageChanger Pchange = PauseImageChange.GetComponent<ImageChanger>();
		GameObject Quad = GameObject.Find("Quad");
		Scroll scroll = Quad.GetComponent<Scroll>();






        if (boundaryCollisionL == true)
        {

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * moveSpeed);
            }
        }
        if (boundaryCollisionR == true)
        {

            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * moveSpeed);
            }
        }
        if (dropCollision == true)
        {
            transform.Translate(new Vector3(0, 0, 0) * Time.deltaTime * 3);
        }
        else
        {
            transform.Translate(new Vector3(0, -2*dropSpeed, 0) * Time.deltaTime * 3);
        }

		if (win == true) {

            //Accelerometer Input
            transform.Translate(0, 0, 0);

            if (Input.GetKey (KeyCode.RightArrow)) {
				transform.Translate (new Vector3 (0, 0, 0) * Time.deltaTime * moveSpeed);
			}

			if (Input.GetKey (KeyCode.LeftArrow)) {
				transform.Translate (new Vector3 (0, 0, 0) * Time.deltaTime * moveSpeed);
			}
		} else {
            //Accelerometer Input
            transform.Translate(Input.acceleration.x / 2, 0, 0);

            if (Input.GetKey (KeyCode.RightArrow)) {
				transform.Translate (new Vector3 (1, 0, 0) * Time.deltaTime * moveSpeed);
			}

			if (Input.GetKey (KeyCode.LeftArrow)) {
				transform.Translate (new Vector3 (-1, 0, 0) * Time.deltaTime * moveSpeed);
			}
		}

    //Liams RagDoll Code Starts
    if (powerUpState == 1) {

			dropSpeed = powerUp1Speed;



		}

			if (GameObject.Find("Head").GetComponent<headBehaviour>().detached == true) {

				dropCollision = true;
				lose = true;
				moveSpeed = 0;
				this.GetComponent<Rigidbody2D>().gravityScale = 1;



			}

        //Liams RagDoll Code Ends


        if (lose == true)
        {
            Time.timeScale = 0;

            int totalScenesLoaded = SceneManager.sceneCount;

            if (totalScenesLoaded == 1)
            {
                Pchange.myCanvas.gameObject.SetActive(false);
                SceneManager.LoadScene("loseMenu", LoadSceneMode.Additive);
            };


        }
        if (win == true && lose == false)
        {
            //Time.timeScale = 0;

            int totalScenesLoaded = SceneManager.sceneCount;

            if (totalScenesLoaded == 1)
            {
                Pchange.myCanvas.gameObject.SetActive(false);
                SceneManager.LoadScene("winMenu", LoadSceneMode.Additive);
            };
        }

		}

    
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "PickUp")
        {
            scoreCount = scoreCount + 10;
            Debug.Log("Count Log " + scoreCount);

        }

		if (col.gameObject.tag == "upObject") {

			up = true;
			dropSpeed = -1.5f;
		}

		if (col.gameObject.tag == "Finish")
		{
			dropCollision = true;
			win = true;
			level = 1;

		}

		if (col.gameObject.tag == "finish1")
		{
			dropCollision = true;
			win = true;
			level = 2;

		}
		if (col.gameObject.tag == "finishFinal")
		{
			dropCollision = true;
			win = true;
			level = 3;

		}

        //Liams Pickup Code Starts

        //Liams Pickup Code Ends
    }

    void OnCollisionEnter2D(Collision2D col)
    {
		if (col.gameObject.tag == "PowerUp1") {

			powerUpState = 1;
		}
        if (col.gameObject.tag == "Walls")
        {
            dropCollision = true;
			lose = true;
        }
        if (col.gameObject.tag == "BoundaryWallsL")
        {
            boundaryCollisionL = true;
        }
        if (col.gameObject.tag == "BoundaryWallsR")
        {
            boundaryCollisionR = true;
        }
        if (col.gameObject.tag == "Finish")
        {
            dropCollision = true;
            win = true;

        }

    }
    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "Walls")
        {
            dropCollision = false;
        }
        if (col.gameObject.tag == "BoundaryWallsL")
        {
            boundaryCollisionL = false;
        }
        if (col.gameObject.tag == "BoundaryWallsR")
        {
            boundaryCollisionR = false;
        }
    }

	void OnGUI()
	{
        GUIStyle myStyle = new GUIStyle();
        myStyle.fontSize = 50;
        myStyle.richText = true;

        GUI.color = Color.black;

        GUI.Label(new Rect(1600, 10, 100, 50), "<b>Score: </b>" + scoreCount, myStyle);
		//if (win == true && lose == false) {
		//	GUI.Label (new Rect (10, 10, 100, 30), "YOU WIN!", myStyle);
		//}


	}


}
