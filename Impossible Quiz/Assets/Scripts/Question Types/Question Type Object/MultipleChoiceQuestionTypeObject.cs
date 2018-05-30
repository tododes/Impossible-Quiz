using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleChoiceQuestionTypeObject : QuestionTypeObject {

	private CommandButton[] buttons;
	
	#region implemented abstract members of QuestionTypeObject
	protected override void initializeQuestionTypeObject (QuestionUIGroup group, QuestionData data)
	{
		buttons = group.GetComponentsInChildren<CommandButton> ();
		questionType = new MultipleChoiceQuestionType (buttons, data.getOptionAnswer(), group.getNextGroup());
	}
	#endregion
	
} 
