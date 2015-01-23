using UnityEngine;
using System.Collections;

public class PlayerBase : MonoBehaviour 
{
	private static PlayerInput _playerInput;
	public static PlayerInput playerInput
	{
		get
		{
			if (_playerInput == null)
			{
				_playerInput = GetComponent<PlayerInput>();
			}
		}
	}
}
