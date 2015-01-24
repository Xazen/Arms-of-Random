using UnityEngine;
using System.Collections;

public class WeaponController : MonoBehaviour {


	PlayerBase _playerBase;

	void Start () {
		_playerBase = GetComponent<PlayerBase>();
		_playerBase.PlayerInput.attack += OnAttack;
	}

	void OnAttack()
	{
		GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube.AddComponent<Rigidbody>();
		cube.transform.position = transform.position;
		cube.AddComponent<ConstantForce>();
		cube.transform.constantForce.force = Vector3.left * 100;
		cube.transform.Translate( Vector3.forward);
	}
}
