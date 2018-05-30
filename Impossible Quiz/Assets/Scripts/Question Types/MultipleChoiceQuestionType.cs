using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleChoiceQuestionType : IQuestionType {

	private QuestionUIGroup nextGroup;

	public MultipleChoiceQuestionType(CommandButton[] choiceButtons, int trueIndex, QuestionUIGroup nextGroup){
		this.nextGroup = nextGroup;

		for (int i = 0; i < choiceButtons.Length; i++) {
			if (i == trueIndex)
				choiceButtons [i].registerCommand (new TrueAnswerCommand (nextGroup));
			else
				choiceButtons [i].registerCommand (new FalseAnswerCommand());
		}
	}
	
	#region IQuestionType implementation
	public void initialize (QuestionUIGroup group, QuestionData data)
	{
		
	}
	public void checkAnswer (string answer, QuestionUIGroup group, QuestionData data)
	{
		int answerInt = 0;
		int.TryParse (answer, out answerInt);

		if (data.getOptionAnswer () == answerInt) {
			new TrueAnswerCommand(nextGroup).OnStartExecute();
		} 
		else {
			new FalseAnswerCommand().OnStartExecute();
		}
	}
	#endregion
	
}
