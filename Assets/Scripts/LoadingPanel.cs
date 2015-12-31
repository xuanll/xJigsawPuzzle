using UnityEngine;
using System.Collections;

public class LoadingPanel : MonoBehaviour {

	// Use this for initialization
	void Start () {

		UIEventListener.Get (GameObject.Find ("Start")).onClick = OnStartClicked;
	}


	//Start Button Click function
	void OnStartClicked(GameObject go)
	{
		//Load jigsaw scene
		Application.LoadLevel ("jigsaw");
	}
}
