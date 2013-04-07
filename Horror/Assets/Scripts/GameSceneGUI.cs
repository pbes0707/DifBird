using UnityEngine;
using System.Collections;

public class GameSceneGUI : MonoBehaviour {

    public GameObject gameCharacter;

	// Use this for initialization
	void Start () {	

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI() {

		int width = 150;
		int height = 45;
		
		int paddingX = 9;
		int paddingY = 6;

		if(GUI.Button(new Rect(Screen.width - width - paddingX, Screen.height - height - paddingY, width, height), Input.mousePosition.ToString())) {
			print("Hello Unity!"); // same Debug.Log();
		}
	}
}
