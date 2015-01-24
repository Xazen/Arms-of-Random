using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

	private ItemBase _itemBase;
	private PlayerBase _playerBase;

	void Start()
	{
		_itemBase = GetComponent<ItemBase> ();
		_playerBase = GameObject.FindGameObjectWithTag (Tags.PLAYER).GetComponent<PlayerBase>();

		_playerBase.PlayerCollision.itemCollision += OnPlayerCollision;
	}

	public void Use()
	{
		if (_itemBase.ItemProperty.CanUseItem ()) 
		{
			_itemBase.ItemProperty.DecreasePosessionCount();
			Debug.Log("weapontype: " + _itemBase.ItemProperty.WeaponType);
		}
	}

	public void OnPlayerCollision(ItemBase itemBase)
	{
		Debug.Log ("Delete item");
		if (!_playerBase.PlayerInventory.IsFull ()) 
		{
			itemBase.ItemVisual.Remove ();
			itemBase.gameObject.renderer.enabled = false;
			itemBase.gameObject.collider.enabled = false;
		}
	}
}
