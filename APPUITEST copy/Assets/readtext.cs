using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/* Script is attached to a button that will start a coroutine that will     */
/* read a string value from the result of tensorflow (ie. fork) and will    */
/* attach itself to a static variable for the scan screen to identify which */
/* directions to give.                                                      */

public class readtext : MonoBehaviour
{

    private string textFromWWW;
    private string url = "http://192.168.43.184/object_detection/resultfile.txt"; // <-- enter your url here

    void Start()
    {
        StartCoroutine(GetTextFromWWW());
    }
		
    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 200), textFromWWW);
    }

    IEnumerator GetTextFromWWW()
	{
		WWW www = new WWW (url);

		yield return www;

		if (www.error != null) {
			Debug.Log ("Ooops, something went wrong...");
		} else {
			textFromWWW = www.text;
			StringScanScript.ApplicationData.displayname = textFromWWW;
		}
	}
}