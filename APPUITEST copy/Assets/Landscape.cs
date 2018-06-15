using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Script is added to a gameobject (manager) in every scene we have to */
/* lock the orientation at landscape.                                  */

public class Landscape : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Screen.orientation = ScreenOrientation.LandscapeLeft;
	}
}
