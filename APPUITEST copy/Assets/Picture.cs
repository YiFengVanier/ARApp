using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using Vuforia;

public class Picture : MonoBehaviour {

	public void Screenshot() {
		ScreenCapture.CaptureScreenshot ("screenshot.png");
	}
}
