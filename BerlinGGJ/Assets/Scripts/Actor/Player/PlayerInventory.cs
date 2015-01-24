using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerInventory : MonoBehaviour {

	private PlayerBase _playerBase;
	private List<ItemBase> _itemList = new List<ItemBase>();

	// Use this for initialization
	void Start () {
		_playerBase = GetComponent<PlayerBase> ();
		_playerBase.PlayerCollision.itemCollision += OnItemCollision;
		_playerBase.PlayerInput.number += ItemSelectedWithIndex;
	}

	public void OnItemCollision(ItemBase itemBase)
	{
		itemBase.ItemProperty.WeaponType = WeaponController.RandomWeaponType ();
		
	}

	public void ItemSelectedWithIndex(int index)
	{
		Debug.Log ("Item selected: " + index);
	}
}
