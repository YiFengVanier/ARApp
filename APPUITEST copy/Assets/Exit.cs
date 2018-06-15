using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Script added to a button that will exit the app to the homescreen of your device */

public class Exit : MonoBehaviour {

	public void exitapp () {
		Application.Quit ();
	}
}