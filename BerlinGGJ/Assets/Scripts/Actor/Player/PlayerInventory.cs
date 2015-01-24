using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerInventory : MonoBehaviour {

	[SerializeField] private int _maxNumberOfItems = 3;
	private PlayerBase _playerBase;
	private List<ItemBase> _itemList = new List<ItemBase>();

	public delegate void InventoryChanged(ItemBase itemBase);
	public event InventoryChanged OnInventoryAdded;
	public event InventoryChanged OnInventoryRemoved;
	public event InventoryChanged OnInventoryUsed;

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
			if (OnInventoryAdded != null)
			{
				OnInventoryAdded(itemBase);
			}
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

			if (OnInventoryUsed != null)
			{
				OnInventoryUsed(itemBase);
			}

			if (!itemBase.ItemProperty.CanUseItem())
			{
				_itemList.RemoveAt(index-1);
				if (OnInventoryRemoved != null)
				{
					OnInventoryRemoved(itemBase);
				}
				Destroy(itemBase.gameObject);
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
