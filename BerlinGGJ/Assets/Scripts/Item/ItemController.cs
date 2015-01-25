using UnityEngine;
using System.Collections;

public class ItemController : MonoBehaviour {

	private ItemBase _itemBase;
	private PlayerBase _playerBase;

	void Start()
	{
		_itemBase = GetComponent<ItemBase> ();
		_playerBase = GameObject.FindGameObjectWithTag (Tags.PLAYER).GetComponent<PlayerBase>();
	}

	public void Use()
	{
		if (_itemBase.ItemProperty.CanUseItem ()) 
		{
			_playerBase.WeaponController.OnAttack(_itemBase.ItemProperty);
		}
	}

	public void Disable()
	{
		_itemBase.gameObject.collider.enabled = false;
	}

	public void Enable()
	{
		_itemBase.gameObject.collider.enabled = true;
	}
}
