using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ContinueButton_1 : MonoBehaviour {

	public string sceneToChoose;

	// Use this for initialization
	void Start () {
		if (GameObject.Find ("NonRagPlayer").GetComponent<PC> ().level == 1) {

			sceneToChoose = "scene1";

		}

		if (GameObject.Find ("NonRagPlayer").GetComponent<PC> ().level == 2) {

			sceneToChoose = "scene4 - space";

		}



		if (GameObject.Find ("NonRagPlayer").GetComponent<PC> ().level == 3) {

			sceneToChoose = "finishmenu";

		}
	
	}

    public void ContinueGame()
    {
		SceneManager.LoadScene(sceneToChoose, LoadSceneMode.Single);

         //Change "scene1" to the name of the next scene in order to continue the level
    }

    // Update is called once per frame
    void Update () {
	
	}
}
