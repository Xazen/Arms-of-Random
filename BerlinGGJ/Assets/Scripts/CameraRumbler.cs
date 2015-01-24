using UnityEngine;
using System.Collections;


public class CameraRumbler : MonoBehaviour 
{
	[SerializeField]
	Camera _camera;
	
	[SerializeField]
	float shake = 1;
	
	[SerializeField]
	float shakeAmount = 0.7f;
	
	[SerializeField]
	float decreaseFactor = 1f;
	
	void Update () 
	{
		if (shake > 0) 
		{
			_camera.transform.localPosition = Random.insideUnitSphere * shakeAmount;
			shake -= Time.deltaTime * decreaseFactor;
		} else 
		{
			shake = 0f;
		}
	}
	
	public void rumble(float _shake, float _shakeAmount)
	{
		shake = _shake;
		shakeAmount = _shakeAmount;
		
	}
}

