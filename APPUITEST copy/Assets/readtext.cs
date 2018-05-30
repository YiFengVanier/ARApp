using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
// This using statement is needed for working with the new GUI system
using UnityEngine.UI;

public class StringDownloader : MonoBehaviour
{
	public string url = "174.20.10.5/upload.php";
	public string webText = string.Empty;
	public Text guiText = null;

	void Start()
	{
		// Start the GetTextFromWebsite Coroutine
		StartCoroutine(GetTextFromWebsite());

	}

	public IEnumerator GetTextFromWebsite()
	{
		// web request object
		WWW webRequest = new WWW(url);

		// wait on the return
		yield return webRequest;

		// Save text to local var if you need it elsewhere
		webText = webRequest.text;

		// Save text to a Text Object directly if needed
		guiText.text = webRequest.text;
	}

	public void ChangeToScene (string sceneToChangeTo) {
		SceneManager.LoadScene(sceneToChangeTo);
	}


}