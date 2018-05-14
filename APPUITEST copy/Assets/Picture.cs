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
		Invoke ("comeback", 1);
		Invoke ("comback2", 1);
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
}
