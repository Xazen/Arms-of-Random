using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerMovement> ().OnPositionChanged += OnPlayerPositionChanged;
	}
	
	// Update is called once per frame
	void OnPlayerPositionChanged(Vector3 position)
	{
		Vector3 newCameraPosition = this.transform.position;
		newCameraPosition.x = position.x;
		this.transform.position = newCameraPosition;
	}
}
