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

	public void use()
	{
		if (_itemBase.ItemProperty.canUseItem ()) 
		{
			_itemBase.ItemProperty.decreasePosessionCount();

		}
	}

	public void OnPlayerCollision(ItemBase itemBase)
	{
		Debug.Log ("Delete item");
		_itemBase.ItemVisual.Remove ();
		Destroy (this.gameObject);
	}
}
