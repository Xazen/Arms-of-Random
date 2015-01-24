using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	private Transform playerOrigin;

	// Use this for initialization
	void Start () {
		GameObject.FindGameObjectWithTag (Tags.PLAYER).GetComponent<PlayerMovement> ().OnPositionChanged += OnPlayerPositionChanged;
		playerOrigin = GameObject.FindGameObjectWithTag (Tags.PLAYER).transform;
	}
	
	// Update is called once per frame
	void OnPlayerPositionChanged(Vector3 position)
	{
		Vector3 newCameraPosition = this.transform.position;
		newCameraPosition.x = position.x+ 12;
		this.transform.position = newCameraPosition;
	}
}
