using UnityEngine;
using System.Collections;

public class BackgroundMovement : MonoBehaviour {

	private Transform playerOrigin;
	
	void Start () {
		GameObject.FindGameObjectWithTag (Tags.PLAYER).GetComponent<PlayerMovement> ().OnPositionChanged += OnPlayerPositionChanged;
		playerOrigin = GameObject.FindGameObjectWithTag (Tags.PLAYER).transform;
	}
	
	void OnPlayerPositionChanged(Vector3 position)
	{
		Vector3 newCameraPosition = this.transform.position;
		newCameraPosition.x = (float) position.x * (-1.02f) + 12;
		this.transform.position = newCameraPosition;
	}
}
