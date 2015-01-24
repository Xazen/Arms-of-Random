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
		if (!IsFull()) 
		{
			itemBase.ItemProperty.WeaponType = WeaponController.RandomWeaponType ();
			_itemList.Add (itemBase);
			Debug.Log("Item collected: " + _itemList);
			Debug.Log("item list count: " + _itemList.Count);
		}
	}

	public void ItemSelectedWithIndex(int index)
	{
		Debug.Log("Should use item with index: " + (index-1));
		Debug.Log("item list count: " + _itemList.Count);
		if (_itemList.Count > index-1) 
		{
			ItemBase itemBase = _itemList[index-1];
			itemBase.Item.Use();
			itemBase.ItemProperty.DecreasePosessionCount();
			if (!itemBase.ItemProperty.CanUseItem())
			{
				_itemList.RemoveAt(index-1);
				Debug.Log("Item removed");
			}
			Debug.Log("Item used: " + _itemList);
		}
	}

	public bool IsFull()
	{
		return (_itemList.Count >= _maxNumberOfItems);
	}
}
