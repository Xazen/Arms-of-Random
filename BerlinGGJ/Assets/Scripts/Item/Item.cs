using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

	private ItemBase _itemBase;

	void Start()
	{
		_itemBase = GetComponent<ItemBase> ();
	}

	public void use()
	{
		if (_itemBase.ItemProperty.canUseItem ()) 
		{
			_itemBase.ItemProperty.decreasePosessionCount();

		}
	}
}
