using UnityEngine;
using System.Collections;

public class MegaController : MonoBehaviour {
	private bool showMenu = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnGUI () {
		if(showMenu) {
			if(GUI.Button (new Rect (0,0,100,50), "Move")){
				transform.position = new Vector2(transform.position.x + 1, transform.position.y + 1);
			}else if(GUI.Button (new Rect (0,50,100,50), "Attack")){
				//Options code goes here
			}else if(GUI.Button (new Rect (0,100,100,50), "Cancel")){
				showMenu = false;
			}
		}
	}

	void OnMouseDown() {
		showMenu = !showMenu;
		if(showMenu) {
			Debug.Log("true");
		} else {
			Debug.Log("false");
		}
	}
}
