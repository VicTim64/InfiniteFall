using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ResumeButton : MonoBehaviour {

    public bool resumeClicked = false;

	// Use this for initialization
	void Start () {

	}

	public void ResumeGame() {
		SceneManager.UnloadScene("pauseMenu");
		Time.timeScale = 1;
        resumeClicked = true;
        Debug.Log(SceneManager.sceneCount);

        GameObject PauseImageChange = GameObject.Find("PauseImageChangerObject");
        ImageChanger Pchange = PauseImageChange.GetComponent<ImageChanger>();

        Pchange.myCanvas.gameObject.SetActive(true);

    }

	// Update is called once per frame
	void Update () {

	}
}
