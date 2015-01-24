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
		_playerBase.PlayerInput.number += ItemUsedWithNumber;
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
		}
	}

	public void ItemUsedWithNumber(int number)
	{
		int index = number - 1;
		if (_itemList.Count > index) 
		{
			ItemBase itemBase = _itemList[index];
			itemBase.Item.Use();
			itemBase.ItemProperty.DecreasePosessionCount();

			if (OnInventoryUsed != null)
			{
				OnInventoryUsed(itemBase);
			}

			if (!itemBase.ItemProperty.CanUseItem())
			{
				_itemList.RemoveAt(index);
				if (OnInventoryRemoved != null)
				{
					OnInventoryRemoved(itemBase);
				}
				Destroy(itemBase.gameObject);
			}
		}
	}

	public List<ItemBase> ItemBaseList()
	{
		return _itemList;
	}

	public int MaximumNumberOfItems()
	{
		return _maxNumberOfItems;
	}

	public bool IsFull()
	{
		return (_itemList.Count >= _maxNumberOfItems);
	}
}
