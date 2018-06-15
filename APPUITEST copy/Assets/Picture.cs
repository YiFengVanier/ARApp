using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using Vuforia;

/* Script is attached to a button and will take a screenshot        */
/* of the current scene (saves on app folder on device). It will    */
/* remove the buttons for the picture and will take you to the url  */
/* running the tensorflow server.                                   */

public class Picture : MonoBehaviour {
	public GameObject ScreenshotButton;
	public GameObject BackButton;

	public void Screenshot() {
		ScreenshotButton.SetActive (false);
		BackButton.SetActive(false);
		Invoke ("comeback", 0);
        Application.OpenURL("http://192.168.43.184/get_img.php");
    }

	void comeback()
		{	
		ScreenCapture.CaptureScreenshot ("screenshot.jpg");
		print (Application.persistentDataPath);
	}
}
