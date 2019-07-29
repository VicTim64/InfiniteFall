using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoseScreenQuit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    public void QuitToMenu()
    {
        SceneManager.LoadScene("mainMenu", LoadSceneMode.Single);
    }

    // Update is called once per frame
    void Update () {
	
	}
}
