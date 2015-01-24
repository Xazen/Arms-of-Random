using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	private Transform playerOrigin;

	void Start () {
		GameObject.FindGameObjectWithTag (Tags.PLAYER).GetComponent<PlayerMovement> ().OnPositionChanged += OnPlayerPositionChanged;
		playerOrigin = GameObject.FindGameObjectWithTag (Tags.PLAYER).transform;
	}

	void OnPlayerPositionChanged(Vector3 position)
	{
		Vector3 newCameraPosition = this.transform.position;
		newCameraPosition.x = position.x + 12;
		newCameraPosition.y = position.y + 12;
		this.transform.position = newCameraPosition;
	}
}
