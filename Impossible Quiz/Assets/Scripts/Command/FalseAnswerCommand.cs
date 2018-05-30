using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalseAnswerCommand : ICommand {

	private Player player;
	
	#region ICommand implementation
	public void OnStartExecute ()
	{
		//player.OnFalseAnswer ();
		Debug.Log ("Answer false");
	}

	public void OnExecute ()
	{
		
	}

	public void OnStopExecute ()
	{
		
	}
	#endregion
	
}
