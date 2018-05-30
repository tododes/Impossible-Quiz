using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class QuestionData {

	[SerializeField, TextArea] private string question;
	[SerializeField] private string[] options;
	[SerializeField] private int optionAnswer;
	[SerializeField] private string nonOptionAnswer;

	public int getOptionAnswer(){
		return optionAnswer;
	}

	public string getQuestion(){
		return question;
	}

	public string[] getOptions(){
		return options;
	}
}
