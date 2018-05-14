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
		ScreenCapture.CaptureScreenshot ("screenshot.png");
		print (Application.persistentDataPath);
		ScreenshotButton.SetActive (true);
		BackButton.SetActive(true);
	}
}
