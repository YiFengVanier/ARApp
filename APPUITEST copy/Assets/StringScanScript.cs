using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StringScanScript : MonoBehaviour {
	public GameObject Scissor;
	public GameObject Cup;	
	public GameObject Fork;	
	public GameObject Dish;
	public GameObject Spoon;	
	public GameObject Knife;	
	public GameObject Pen;	
	public GameObject Cardboard;	
	public GameObject Tissue;	
	public GameObject Book;	
	public GameObject Keyboard;	
	public GameObject Arrow;
	public Text text;

	public static class ApplicationData {
		public static string displayname;
	}

	void Update () {

		//Shows all containers
		if (ApplicationData.displayname == "") {
			text.text = "Scanning for All";
			Scissor.SetActive (true);
			Cup.SetActive (true);
			Fork.SetActive (true);
			Dish.SetActive (true);
			Spoon.SetActive (true);
			Knife.SetActive (true);
			Pen.SetActive (true);
			Cardboard.SetActive (true);
			Tissue.SetActive (true);
			Book.SetActive (true);
			Keyboard.SetActive (true);	
			Arrow.SetActive (false);
		}

		//Shows only Dish container
		if (ApplicationData.displayname == "dish") {
			text.text = "Scanning for Dishes";
			Scissor.SetActive (false);
			Cup.SetActive (false);
			Fork.SetActive (false);
			Dish.SetActive (true);
			Spoon.SetActive (false);
			Knife.SetActive (false);
			Pen.SetActive (false);
			Cardboard.SetActive (false);
			Tissue.SetActive (false);
			Book.SetActive (false);
			Keyboard.SetActive (false);	
			Arrow.SetActive (true);
		}

		//Shows only Fork container
		if (ApplicationData.displayname == "fork") {
			text.text = "Scanning for Forks";
			Scissor.SetActive (false);
			Cup.SetActive (false);
			Fork.SetActive (true);
			Dish.SetActive (false);
			Spoon.SetActive (false);
			Knife.SetActive (false);
			Pen.SetActive (false);
			Cardboard.SetActive (false);
			Tissue.SetActive (false);
			Book.SetActive (false);
			Keyboard.SetActive (false);	
			Arrow.SetActive (true);
		}

		//Shows only Cup container
		if (ApplicationData.displayname == "cup") {
			text.text = "Scanning for Cups";
			Scissor.SetActive (false);
			Cup.SetActive (true);
			Fork.SetActive (false);
			Dish.SetActive (false);
			Spoon.SetActive (false);
			Knife.SetActive (false);
			Pen.SetActive (false);
			Cardboard.SetActive (false);
			Tissue.SetActive (false);
			Book.SetActive (false);
			Keyboard.SetActive (false);		
			Arrow.SetActive (true);
		}

		//Shows only Scissor container
		if (ApplicationData.displayname == "scissor") {
			text.text = "Scanning for Scissors";
			Scissor.SetActive (true);
			Cup.SetActive (false);
			Fork.SetActive (false);
			Dish.SetActive (false);
			Spoon.SetActive (false);
			Knife.SetActive (false);
			Pen.SetActive (false);
			Cardboard.SetActive (false);
			Tissue.SetActive (false);
			Book.SetActive (false);
			Keyboard.SetActive (false);	
			Arrow.SetActive (true);
		}

		//Shows only Spoon container
		if (ApplicationData.displayname == "spoon") {
			text.text = "Scanning for Spoons";
			Scissor.SetActive (false);
			Cup.SetActive (false);
			Fork.SetActive (false);
			Dish.SetActive (false);
			Spoon.SetActive (true);
			Knife.SetActive (false);
			Pen.SetActive (false);
			Cardboard.SetActive (false);
			Tissue.SetActive (false);
			Book.SetActive (false);
			Keyboard.SetActive (false);	
			Arrow.SetActive (true);
		}

		//Shows only Knife container
		if (ApplicationData.displayname == "knife") {
			text.text = "Scanning for Knives";
			Scissor.SetActive (false);
			Cup.SetActive (false);
			Fork.SetActive (false);
			Dish.SetActive (false);
			Spoon.SetActive (false);
			Knife.SetActive (true);
			Pen.SetActive (false);
			Cardboard.SetActive (false);
			Tissue.SetActive (false);
			Book.SetActive (false);
			Keyboard.SetActive (false);	
			Arrow.SetActive (true);
		}

		//Shows only Pen container
		if (ApplicationData.displayname == "pen") {
			text.text = "Scanning for Pens";
			Scissor.SetActive (false);
			Cup.SetActive (false);
			Fork.SetActive (false);
			Dish.SetActive (false);
			Spoon.SetActive (false);
			Knife.SetActive (false);
			Pen.SetActive (true);
			Cardboard.SetActive (false);
			Tissue.SetActive (false);
			Book.SetActive (false);
			Keyboard.SetActive (false);	
			Arrow.SetActive (true);
		}

		//Shows only Cardboard container
		if (ApplicationData.displayname == "cardboard") {
			text.text = "Scanning for Cardboard";
			Scissor.SetActive (false);
			Cup.SetActive (false);
			Fork.SetActive (false);
			Dish.SetActive (false);
			Spoon.SetActive (false);
			Knife.SetActive (false);
			Pen.SetActive (false);
			Cardboard.SetActive (true);
			Tissue.SetActive (false);
			Book.SetActive (false);
			Keyboard.SetActive (false);	
			Arrow.SetActive (true);
		}

		//Shows only Tissue container
		if (ApplicationData.displayname == "tissue") {
			text.text = "Scanning for Tissues";
			Scissor.SetActive (false);
			Cup.SetActive (false);
			Fork.SetActive (false);
			Dish.SetActive (false);
			Spoon.SetActive (false);
			Knife.SetActive (false);
			Pen.SetActive (false);
			Cardboard.SetActive (false);
			Tissue.SetActive (true);
			Book.SetActive (false);
			Keyboard.SetActive (false);	
			Arrow.SetActive (true);
		}

		//Shows only Book container
		if (ApplicationData.displayname == "book") {
			text.text = "Scanning for Books";
			Scissor.SetActive (false);
			Cup.SetActive (false);
			Fork.SetActive (false);
			Dish.SetActive (false);
			Spoon.SetActive (false);
			Knife.SetActive (false);
			Pen.SetActive (false);
			Cardboard.SetActive (false);
			Tissue.SetActive (false);
			Book.SetActive (true);
			Keyboard.SetActive (false);	
			Arrow.SetActive (true);
		}

		//Shows only Keyboard container
		if (ApplicationData.displayname == "keyboard") {
			text.text = "Scanning for Keyboards";
			Scissor.SetActive (false);
			Cup.SetActive (false);
			Fork.SetActive (false);
			Dish.SetActive (false);
			Spoon.SetActive (false);
			Knife.SetActive (false);
			Pen.SetActive (false);
			Cardboard.SetActive (false);
			Tissue.SetActive (false);
			Book.SetActive (false);
			Keyboard.SetActive (true);	
			Arrow.SetActive (true);
		}

	}

}
