using UnityEngine;
using System.Collections;

public class SceneSingleton<T> : MonoBehaviour where T : Component
{
	public static T SceneInstance
	{
		get
		{
			T instancedObject = FindObjectOfType (typeof(T)) as T;
			if (instancedObject == null)
			{
				GameObject obj = new GameObject ();
				obj.hideFlags = HideFlags.HideAndDontSave;
				instancedObject = obj.AddComponent (typeof(T)) as T;
			}

			return instancedObject;
		}
	}
}