using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class position2 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Input.compass.enabled = true;
        Input.location.Start();
    }

	// Update is called once per frame
	void Update()
	{
		var xrot = Mathf.Atan2(Input.acceleration.z, Input.acceleration.y);
		var yzmag = Mathf.Sqrt(Mathf.Pow(Input.acceleration.y, 2) + Mathf.Pow(Input.acceleration.z, 2));
		var zrot = Mathf.Atan2(Input.acceleration.x, yzmag);

		var xangle = xrot * (180 / Mathf.PI) + 90;
		var zangle = -zrot * (180 / Mathf.PI);

		//no arrows for all
		if (StringScanScript.ApplicationData.displayname == "") 
		{
		}
		//arrow for 4 cabinet
		if ((StringScanScript.ApplicationData.displayname == "dish")  || (StringScanScript.ApplicationData.displayname == "fork") || (StringScanScript.ApplicationData.displayname == "cup") || (StringScanScript.ApplicationData.displayname == "scissor")) 
		{
			transform.eulerAngles = new Vector3 ((xangle - (xangle % 1)), 0, ((zangle - Input.compass.trueHeading) - ((zangle - Input.compass.trueHeading) % 1)) - 70);
		}
		//arrow for 3 desk
		if ((StringScanScript.ApplicationData.displayname == "pen") || (StringScanScript.ApplicationData.displayname == "spoon") || (StringScanScript.ApplicationData.displayname == "keyboard")) 
		{
			transform.eulerAngles = new Vector3 ((xangle - (xangle % 1)), 0, ((zangle - Input.compass.trueHeading) - ((zangle - Input.compass.trueHeading) % 1)) - 110);
		}
		//arrow for right wood cabinet
		if ((StringScanScript.ApplicationData.displayname == "cardboard") || (StringScanScript.ApplicationData.displayname == "mouse")) 
		{
			transform.eulerAngles = new Vector3 ((xangle - (xangle % 1)), 0, ((zangle - Input.compass.trueHeading) - ((zangle - Input.compass.trueHeading) % 1)) - 170);
		}
		//arrow for left wood cabinet
		if ((StringScanScript.ApplicationData.displayname == "book") || (StringScanScript.ApplicationData.displayname == "knife")) 
		{
			transform.eulerAngles = new Vector3 ((xangle - (xangle % 1)), 0, ((zangle - Input.compass.trueHeading) - ((zangle - Input.compass.trueHeading) % 1)) - 260);
		}
	}
}
