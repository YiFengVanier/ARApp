using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchBar : MonoBehaviour {
	public GameObject button1;
	public GameObject button2;	

	void start () {
		button1.SetActive (false);
		button2.SetActive (false);
	}

	public void ButtonValid () {
		button1.SetActive (false);
		button2.SetActive (true);
	}
}
