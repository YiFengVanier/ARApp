using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Flashlight : MonoBehaviour {

	public void turnon (int toggle) {
		if (toggle == 1) {
			CameraDevice.Instance.SetFlashTorchMode (false);
		}
		if (toggle == 0) {
			CameraDevice.Instance.SetFlashTorchMode (true);
		}
	}
}
