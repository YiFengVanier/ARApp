using UnityEngine;
using System.Collections;
//using UnityEngine.SceneManagement;
// This using statement is needed for working with the new GUI system
using UnityEngine.UI;

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
        WWW www = new WWW(url);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Ooops, something went wrong...");
        }
        else
        {
            textFromWWW = www.text;
			StringScanScript.ApplicationData.displayname = textFromWWW;
        }
    }



}