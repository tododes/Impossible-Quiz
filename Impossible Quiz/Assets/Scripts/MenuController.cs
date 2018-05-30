using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour {

	public static MenuController singleton { get; private set; }

    [SerializeField] private MenuUIGroup initialGroup;
    [SerializeField] private Stack<MenuUIGroup> groups = new Stack<MenuUIGroup>();

    void Awake() {
		singleton = this;
        pushUIGroup(initialGroup);
    }

    public void pushUIGroup(MenuUIGroup group) {
        if(groups.Count() > 0)
            groups.Top().hide();
		
        groups.Add(group);
        groups.Top().display();
    }

    public void popUIGroup() {
        if (groups.Count() > 0) {
            groups.Top().hide();
            groups.Remove();

        }

		if(groups.Count() > 0)
			groups.Top().display();
    }
}
