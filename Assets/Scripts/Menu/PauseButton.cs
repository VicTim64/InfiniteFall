using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseButton : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
		

	public void PauseGame() {
		GameObject PauseImageChange = GameObject.Find ("PauseImageChangerObject");
		ImageChanger Pchange = PauseImageChange.GetComponent<ImageChanger>();

        if (Pchange.PlayBool == false)
        {
            SceneManager.LoadScene("pauseMenu", LoadSceneMode.Additive);
            // GameObject ResumeClickChecker = GameObject.Find("ResumeObject");
            // ResumeButton Rchange = ResumeClickChecker.GetComponent<ResumeButton>();
            // Debug.Log(SceneManager.sceneCount);


           // if (Rchange.resumeClicked == true)
           // {
           //     Pchange.Tester1();
           // }
        }


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}