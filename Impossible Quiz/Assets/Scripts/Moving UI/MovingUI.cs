using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MovingUI : MonoBehaviour {

    protected IDisplayBehaviour displayBehaviour;

    // Use this for initialization
    protected void Awake () {
        Initialize();
	}

    // Update is called once per frame
    protected void Update () {
        displayBehaviour.tick();
	}

    public void setDisplayBehaviour(IDisplayBehaviour displayBehaviour) {
        this.displayBehaviour = displayBehaviour;
    }

    protected abstract void Initialize();

    public void display() {
		if (displayBehaviour == null)
			Debug.Log (gameObject + " display null");
        displayBehaviour.display();
    }

    public void hide() {
        displayBehaviour.hide();
    }
}
