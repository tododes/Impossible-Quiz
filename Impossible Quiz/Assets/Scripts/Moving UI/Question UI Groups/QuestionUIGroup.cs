using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionUIGroup : MenuUIGroup {

	[SerializeField] protected QuestionData questionData;
	[SerializeField] protected QuestionUIGroup nextGroup;
	[SerializeField] protected QuestionTypeObject typeObject;
	[SerializeField] private Text questionText;

	private CommandButton[] buttons;
	
	#region implemented abstract members of MenuUIGroup
	protected override void InitializeGroup (){
		setDisplayBehaviour (new NullDisplayBehaviour());
		questionText.text = questionData.getQuestion ();

		buttons = GetComponentsInChildren<CommandButton> ();
		string[] options = questionData.getOptions ();

		for (int i = 0; i < buttons.Length; i++) {
			buttons [i].setChildTextString (options[i]);
		}

		typeObject.initialize (this, questionData);
	}
	#endregion

	public QuestionUIGroup getNextGroup(){
		return nextGroup;
	}
}
