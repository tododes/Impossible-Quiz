using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrueAnswerCommand : ICommand {

	private QuestionUIGroup nextGroup;

	public TrueAnswerCommand(QuestionUIGroup nextGroup){
		this.nextGroup = nextGroup;
	}
	
	#region ICommand implementation
	public void OnStartExecute ()
	{
		Debug.Log ("Answer true");
		//MenuController.singleton.pushUIGroup (nextGroup);
	}

	public void OnExecute ()
	{
		
	}

	public void OnStopExecute ()
	{
		
	}
	#endregion
	
}
