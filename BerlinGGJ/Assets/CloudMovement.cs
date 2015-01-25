using UnityEngine;
using System.Collections;

public class CloudMovement : MonoBehaviour {

	[SerializeField]
	float speed = 1f;

	[SerializeField]
	float randomness = 0.5f;

	void Update () {
		transform.Translate(Vector3.right * speed * Random.Range(0.01f, randomness));	
	}
}
