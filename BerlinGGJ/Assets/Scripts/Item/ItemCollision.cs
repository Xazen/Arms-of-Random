using UnityEngine;
using System.Collections;

public class ItemCollision : MonoBehaviour {

	private ItemBase _itemBase;
	private PlayerBase _playerBase;

	void Start()
	{
		_itemBase = GetComponent<ItemBase> ();
		_playerBase = GameObject.FindGameObjectWithTag (Tags.PLAYER).GetComponent<PlayerBase>();
		_playerBase.PlayerCollision.itemCollision += OnPlayerCollision;
	}

	public void OnPlayerCollision(ItemBase itemBase)
	{
		if (!_playerBase.PlayerInventory.IsFull ()) 
		{
			itemBase.ItemVisual.Disappear ();
		}
	}
}
