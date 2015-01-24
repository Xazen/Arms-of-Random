using UnityEngine;
using System.Collections;

public class WeaponController : MonoBehaviour {

	PlayerBase _playerBase;

	void Start () {
		_playerBase = GetComponent<PlayerBase>();
		_playerBase.PlayerInput.attack += OnAttack;
	}

	void OnAttack(int attackType)
	{
		if(attackType == 101)
		{
			GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
			cube.AddComponent<Rigidbody>();
			cube.transform.position = transform.position;
			cube.AddComponent<ConstantForce>();
			cube.transform.constantForce.force = Vector3.right * 100;
			cube.transform.Translate( Vector3.forward );
		}
	}
}
