using UnityEngine;
using System.Collections;

public class TestComponent : MonoBehaviour 
{
	private void OnGUI () 
	{
		if (GUI.Button(new Rect(10, 70, 50, 30), "Click"))
			Debug.Log("Clicked the button with text");

		if (GUI.Button(new Rect(10, 100, 50, 30), "Show screenLogger"))
			Locator.ScreenLogger.IsVisible = !Locator.ScreenLogger.IsVisible;
	}
}
