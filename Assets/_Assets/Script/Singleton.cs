using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;
using DG.Tweening;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour {

	public static T instance;

	public static T Instance {
		get {
			if (instance == null) {
				instance = FindObjectOfType<T>();
				if (instance == null) {
					GameObject go = new GameObject();
					instance = go.AddComponent<T>();
					go.name = typeof(T).ToString() + "(Singleton)"; ;
					DontDestroyOnLoad(go);
				}
			}
			return instance;
		}
	}
}