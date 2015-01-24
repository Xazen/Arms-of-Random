using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerInventory : MonoBehaviour {

	[SerializeField] private int _maxNumberOfItems = 3;
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
		if (!IsFull) 
		{
			itemBase.ItemProperty.WeaponType = WeaponController.RandomWeaponType ();
			_itemList.Add (itemBase);
		}
	}

	public void ItemSelectedWithIndex(int index)
	{
		if (_itemList.Count >= index) 
		{
			ItemBase itemBase = _itemList[index];
			_itemList.RemoveAt(index);
		}
	}

	public bool IsFull()
	{
		return (_itemList.Count < _maxNumberOfItems);
	}
}
