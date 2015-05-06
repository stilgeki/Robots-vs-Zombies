using UnityEngine;
using System.Collections;

public class CameraMoveScript : MonoBehaviour {

	public GameObject gameObject;
	Vector3 position;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		position = gameObject.transform.position;

		if (Input.GetKey (KeyCode.A)) {
			//gameObject.transform.position.x++;
			position.x--;
		} else if (Input.GetKey (KeyCode.D)) {
			//gameObject.transform.position.x--;
			position.x++;
		} else if (Input.GetKey (KeyCode.W)) {
			//gameObject.transform.position.z++;
			position.z++;
		} else if (Input.GetKey (KeyCode.S)) {
			//gameObject.transform.position.z--;
			position.z--;
		}

		gameObject.transform.position = position;
	}
}
