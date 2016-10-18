using UnityEngine;
using System.Collections;

public class MenuSettings : MonoBehaviour {

	public static MenuSettings Instance;

	public float stareTriggerLength = .3f;

	void Start () 
	{
		Instance = this;
		// load previous settings
	}

	void OnDisable()
	{
		// save settings
	}
		
}
