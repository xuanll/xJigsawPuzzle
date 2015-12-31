using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MainPanel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		UIEventListener.Get (GameObject.Find ("Back")).onClick = OnBackClicked;
	}

	void OnBackClicked(GameObject go)
	{
		//Load Loading scene
		Application.LoadLevel ("Loading");
	}

}
