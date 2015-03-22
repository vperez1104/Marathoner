using UnityEngine;
using System.Collections;

public class StartButton : MonoBehaviour {

	// Update is called once per frame
	public void StartGame (string sceneschange) {
		Application.LoadLevel (sceneschange);
	
	}
}
