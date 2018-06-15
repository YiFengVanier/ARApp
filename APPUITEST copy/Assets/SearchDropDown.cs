using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* Script is connected to a dropdown object in the Scan Screen. Unity dropdowns */
/* give a value from 0 the top option and add 1 for each one down. This script  */
/* will make the arrow appear when searching for a specific container, outline  */
/* that container, and will tell you what you are searching for. */

public class SearchDropDown : MonoBehaviour {
	public GameObject Scissor;
	public GameObject Cup;	
	public GameObject Fork;	
	public GameObject Dish;
	public GameObject Spoon;	
	public GameObject Keyboard;	
	public GameObject Pen;	
	public GameObject Cardboard;	
	public GameObject Mouse;	
	public GameObject Book;	
	public GameObject Knife;	
	public GameObject Arrow;

	public Dropdown dropdown;
	public Text text;

	void Update () {
		
		//Shows all containers
		if (dropdown.value == 0) {
			text.text = "Scanning for All";
			Scissor.SetActive (true);
			Cup.SetActive (true);
			Fork.SetActive (true);
			Dish.SetActive (true);
			Spoon.SetActive (true);
			Knife.SetActive (true);
			Pen.SetActive (true);
			Cardboard.SetActive (true);
			Mouse.SetActive (true);
			Book.SetActive (true);
			Keyboard.SetActive (true);	
			Arrow.SetActive (false);
		}

		//Shows only Dish container
		if (dropdown.value == 1) {
			text.text = "Scanning for Dishes";
			Scissor.SetActive (false);
			Cup.SetActive (false);
			Fork.SetActive (false);
			Dish.SetActive (true);
			Spoon.SetActive (false);
			Knife.SetActive (false);
			Pen.SetActive (false);
			Cardboard.SetActive (false);
			Mouse.SetActive (false);
			Book.SetActive (false);
			Keyboard.SetActive (false);	
			Arrow.SetActive (true);
		}

		//Shows only Fork container
		if (dropdown.value == 2) {
			text.text = "Scanning for Forks";
			Scissor.SetActive (false);
			Cup.SetActive (false);
			Fork.SetActive (true);
			Dish.SetActive (false);
			Spoon.SetActive (false);
			Knife.SetActive (false);
			Pen.SetActive (false);
			Cardboard.SetActive (false);
			Mouse.SetActive (false);
			Book.SetActive (false);
			Keyboard.SetActive (false);	
			Arrow.SetActive (true);
		}

		//Shows only Cup container
		if (dropdown.value == 3) {
			text.text = "Scanning for Cups";
			Scissor.SetActive (false);
			Cup.SetActive (true);
			Fork.SetActive (false);
			Dish.SetActive (false);
			Spoon.SetActive (false);
			Knife.SetActive (false);
			Pen.SetActive (false);
			Cardboard.SetActive (false);
			Mouse.SetActive (false);
			Book.SetActive (false);
			Keyboard.SetActive (false);		
			Arrow.SetActive (true);
		}

		//Shows only Scissor container
		if (dropdown.value == 4) {
			text.text = "Scanning for Scissors";
			Scissor.SetActive (true);
			Cup.SetActive (false);
			Fork.SetActive (false);
			Dish.SetActive (false);
			Spoon.SetActive (false);
			Knife.SetActive (false);
			Pen.SetActive (false);
			Cardboard.SetActive (false);
			Mouse.SetActive (false);
			Book.SetActive (false);
			Keyboard.SetActive (false);	
			Arrow.SetActive (true);
		}

		//Shows only Spoon container
		if (dropdown.value == 5) {
			text.text = "Scanning for Spoons";
			Scissor.SetActive (false);
			Cup.SetActive (false);
			Fork.SetActive (false);
			Dish.SetActive (false);
			Spoon.SetActive (true);
			Knife.SetActive (false);
			Pen.SetActive (false);
			Cardboard.SetActive (false);
			Mouse.SetActive (false);
			Book.SetActive (false);
			Keyboard.SetActive (false);	
			Arrow.SetActive (true);
		}

		//Shows only Keyboard container
		if (dropdown.value == 6) {
			text.text = "Scanning for Keyboard";
			Scissor.SetActive (false);
			Cup.SetActive (false);
			Fork.SetActive (false);
			Dish.SetActive (false);
			Spoon.SetActive (false);
			Knife.SetActive (false);
			Pen.SetActive (false);
			Cardboard.SetActive (false);
			Mouse.SetActive (false);
			Book.SetActive (false);
			Keyboard.SetActive (true);	
			Arrow.SetActive (true);
		}

		//Shows only Pen container
		if (dropdown.value == 7) {
			text.text = "Scanning for Pens";
			Scissor.SetActive (false);
			Cup.SetActive (false);
			Fork.SetActive (false);
			Dish.SetActive (false);
			Spoon.SetActive (false);
			Knife.SetActive (false);
			Pen.SetActive (true);
			Cardboard.SetActive (false);
			Mouse.SetActive (false);
			Book.SetActive (false);
			Keyboard.SetActive (false);	
			Arrow.SetActive (true);
		}

		//Shows only Cardboard container
		if (dropdown.value == 8) {
			text.text = "Scanning for Cardboard";
			Scissor.SetActive (false);
			Cup.SetActive (false);
			Fork.SetActive (false);
			Dish.SetActive (false);
			Spoon.SetActive (false);
			Knife.SetActive (false);
			Pen.SetActive (false);
			Cardboard.SetActive (true);
			Mouse.SetActive (false);
			Book.SetActive (false);
			Keyboard.SetActive (false);	
			Arrow.SetActive (true);
		}

		//Shows only Mouse container
		if (dropdown.value == 9) {
			text.text = "Scanning for Mouses";
			Scissor.SetActive (false);
			Cup.SetActive (false);
			Fork.SetActive (false);
			Dish.SetActive (false);
			Spoon.SetActive (false);
			Knife.SetActive (false);
			Pen.SetActive (false);
			Cardboard.SetActive (false);
			Mouse.SetActive (true);
			Book.SetActive (false);
			Keyboard.SetActive (false);	
			Arrow.SetActive (true);
		}

		//Shows only Book container
		if (dropdown.value == 10) {
			text.text = "Scanning for Books";
			Scissor.SetActive (false);
			Cup.SetActive (false);
			Fork.SetActive (false);
			Dish.SetActive (false);
			Spoon.SetActive (false);
			Knife.SetActive (false);
			Pen.SetActive (false);
			Cardboard.SetActive (false);
			Mouse.SetActive (false);
			Book.SetActive (true);
			Keyboard.SetActive (false);	
			Arrow.SetActive (true);
		}

		//Shows only Knife container
		if (dropdown.value == 11) {
			text.text = "Scanning for Knives";
			Scissor.SetActive (false);
			Cup.SetActive (false);
			Fork.SetActive (false);
			Dish.SetActive (false);
			Spoon.SetActive (false);
			Knife.SetActive (true);
			Pen.SetActive (false);
			Cardboard.SetActive (false);
			Mouse.SetActive (false);
			Book.SetActive (false);
			Keyboard.SetActive (false);	
			Arrow.SetActive (true);
		}

	}

}
