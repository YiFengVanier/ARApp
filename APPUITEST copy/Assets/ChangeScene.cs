using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

/* Script is attached to a button that will change the scene in unity     */
/* Script can also be used as a refresh button, such as one of our scenes */

public class ChangeScene : MonoBehaviour {

	public void ChangeToScene (string sceneToChangeTo) {
		SceneManager.LoadScene(sceneToChangeTo);
	}
}
