using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour {

    // Use this for initialization
    string currentSceneTest;

	void Start () {
	
	}

    public void RestartGame()
    {
        currentSceneTest = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneTest, LoadSceneMode.Single);
    }

    // Update is called once per frame
    void Update () {
	
	}
}
