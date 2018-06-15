using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using Vuforia;

/* Script is attached to a button that will turn the flashlight */
/* of your device when held down and turn it off when not held. */

public class Flashlight : MonoBehaviour{

	public void onPointerDownFlashlightButton()
	{
		CameraDevice.Instance.SetFlashTorchMode(true);
	}
	public void onPointerUpFlashlightButton()
	{
		CameraDevice.Instance.SetFlashTorchMode(false);
	}
}
