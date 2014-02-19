using UnityEngine;

public class ScreenLogger : SceneSingleton<ScreenLogger> 
{
	private static string myLog = string.Empty;
	private string output = string.Empty;
	private Rect rect;

	public bool IsVisible 
	{
		get;
		set;
	}

	private void Start ()
	{
		rect = new Rect (10, 10, Screen.width-10, Screen.height-10);
	}

	private void Awake () 
	{
		Application.RegisterLogCallback(HandleLog);
	}
	
	private void OnDestroy () 
	{
		Application.RegisterLogCallback(null);
	}
	
	private void HandleLog (string logString, string stackTrace, LogType type) 
	{
		output = logString;
		myLog +="\n"+output;
	}
	
	private void OnGUI () 
	{
		if (IsVisible)
			myLog = GUI.TextArea (rect, myLog);
	}
}
