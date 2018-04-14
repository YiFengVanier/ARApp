using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchDropDown : MonoBehaviour {
	public GameObject Scissor;
	public GameObject Cup;	
	public GameObject Fork;	
	public GameObject Dish;	

	public Dropdown dropdown;
	public Text text;

	void Update () {

		if (dropdown.value == 0) {
			text.text = "Scanning for All";
			Scissor.SetActive (true);
			Cup.SetActive (true);
			Fork.SetActive (true);
			Dish.SetActive (true);
		}

		if (dropdown.value == 1) {
			text.text = "Scanning for Dishes";
			Scissor.SetActive (false);
			Cup.SetActive (false);
			Fork.SetActive (false);
			Dish.SetActive (true);
		}

		if (dropdown.value == 2) {
			text.text = "Scanning for Forks";
			Scissor.SetActive (false);
			Cup.SetActive (false);
			Fork.SetActive (true);
			Dish.SetActive (false);
		}

		if (dropdown.value == 3) {
			text.text = "Scanning for Cups";
			Scissor.SetActive (false);
			Cup.SetActive (true);
			Fork.SetActive (false);
			Dish.SetActive (false);
		}

		if (dropdown.value == 4) {
			text.text = "Scanning for Scissors";
			Scissor.SetActive (true);
			Cup.SetActive (false);
			Fork.SetActive (false);
			Dish.SetActive (false);
		}

	}

}

