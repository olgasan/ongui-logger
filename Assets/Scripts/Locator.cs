using UnityEngine;
using System.Collections;

public class Locator 
{
	private static Locator myInstance;
	
	public static Locator Instance
	{
		get
		{
			if (myInstance == null)
				myInstance = new Locator ();
			
			return myInstance;
		}
	}

	private Locator ()
	{
	}

	#region access to decoupled singletons
	
	private ScreenLogger screenLogger;
	public static ScreenLogger ScreenLogger
	{
		get 
		{
			if (Instance.screenLogger == null)
				Instance.screenLogger = ScreenLogger.SceneInstance;
			
			return Instance.screenLogger; 
		}
	}

	#endregion
}