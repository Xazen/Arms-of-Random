﻿using UnityEngine;
using System.Collections;

public class WeaponController : MonoBehaviour {

	[SerializeField] private GameObject _projectile;
	PlayerBase _playerBase;

	void Start () {
		_playerBase = GameObject.FindGameObjectWithTag(Tags.PLAYER).GetComponent<PlayerBase>();
		_playerBase.PlayerInput.attack += OnAttack;
	}

	void OnAttack(int attackType)
	{
		if(attackType == 101)
		{
			GameObject projectile = (GameObject) Instantiate(_projectile, transform.position, Quaternion.identity);
			projectile.transform.constantForce.force = Vector3.right * 100;
			projectile.transform.Translate( Vector3.forward );
		}
	}
}
