﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private int health;

	// Use this for initialization
	void Start () {
		health = 3;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnFalseAnswer(){
		health--;
	}
}
