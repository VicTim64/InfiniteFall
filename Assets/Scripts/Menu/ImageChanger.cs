using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ImageChanger : MonoBehaviour {

	// Use this for initialization
	public Sprite spriteToChangeTo;
    public Sprite spriteToReturnTo;
    public bool PlayBool = false;
    public bool testerBool = false;
    public Canvas myCanvas;

    public void ChangeImage(Image myImageToUpdate)
	{
		
        Time.timeScale = 0;
        myCanvas.gameObject.SetActive(false);
        //myImageToUpdate.sprite = spriteToChangeTo;

        // PlayBool = !PlayBool;


    }
	void Update(){

	}

    public void Tester1()
    {

        testerBool = true;


    }
}
