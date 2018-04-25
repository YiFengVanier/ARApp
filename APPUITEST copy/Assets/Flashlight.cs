using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using Vuforia;

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
