using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class QuestionTypeObject : ScriptableObject {

	protected IQuestionType questionType;

	public void initialize(QuestionUIGroup group, QuestionData data){
		initializeQuestionTypeObject (group, data);
		questionType.initialize (group, data);
	}

	public void checkAnswer(string answer, QuestionUIGroup group, QuestionData data){
		questionType.checkAnswer (answer, group, data);
	}

	protected abstract void initializeQuestionTypeObject (QuestionUIGroup group, QuestionData data);
}
