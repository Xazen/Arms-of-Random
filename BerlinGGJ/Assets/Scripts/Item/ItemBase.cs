using UnityEngine;
using System.Collections;

public class ItemBase : MonoBehaviour {

	private Item _item;
	public Item Item
	{
		get
		{
			if(_item == null)
			{
				_item = GetComponent<Item>();
			}
			return _item;
		}
	}

	private ItemProperty _itemProperties;
	public ItemProperty ItemProperty
	{
		get 
		{
			if (_itemProperties == null)
			{
				_itemProperties = GetComponent<ItemProperty>();
			}
			return _itemProperties;
		}
	}
}
