using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IQuestionType {
	void initialize(QuestionUIGroup group, QuestionData data);
	void checkAnswer(string answer, QuestionUIGroup group, QuestionData data);
}
