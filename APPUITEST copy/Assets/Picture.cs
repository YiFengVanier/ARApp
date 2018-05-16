using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using Vuforia;

public class Picture : MonoBehaviour {
	public GameObject ScreenshotButton;
	public GameObject BackButton;

	public void Screenshot() {
		ScreenshotButton.SetActive (false);
		BackButton.SetActive(false);
		Invoke ("comeback", 0);
		Invoke ("comeback2", 1);
	}

	void comeback()
		{	
		ScreenCapture.CaptureScreenshot ("screenshot.png");
		print (Application.persistentDataPath);
		}

	void comeback2()
	{
		ScreenshotButton.SetActive (true);
		BackButton.SetActive (true);
	}

	void ConnectToServer() {
		Network.Connect ("127.0.0.1", 25000);
	}


}
