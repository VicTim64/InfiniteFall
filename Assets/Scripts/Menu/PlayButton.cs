using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class PlayButton : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
    public void PlayGame()
    {
		SceneManager.LoadScene("scene3", LoadSceneMode.Single);
    }
    void Update()
    {

    }
}