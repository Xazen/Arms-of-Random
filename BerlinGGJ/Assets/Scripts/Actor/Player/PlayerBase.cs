using UnityEngine;
using System.Collections;

public class PlayerBase : ActorBase 
{
	private PlayerInput _playerInput;
	public PlayerInput PlayerInput
	{
		get
		{
			if (_playerInput == null)
			{
				_playerInput = GetComponent<PlayerInput>();
			}

			return _playerInput;
		}
	}

	private PlayerMovement _playerMovement;
	public PlayerMovement PlayerMovement
	{
		get
		{
			if (_playerMovement == null)
			{
				_playerMovement = GetComponent<PlayerMovement>();
			}
			return _playerMovement;
		}
	}

	private PlayerCollision _playerCollision;
	public PlayerCollision PlayerCollision
	{
		get
		{
			if (_playerCollision == null)
			{
				_playerCollision = GetComponent<PlayerCollision>();
			}
			return _playerCollision;
		}
	}
		
	private PlayerInventory _playerInventory;
	public PlayerInventory PlayerInventory
	{
		get
		{
			if (_playerInventory == null)
			{
				_playerInventory = GetComponent<PlayerInventory>();
			}
			return _playerInventory;
		}
	}
}
