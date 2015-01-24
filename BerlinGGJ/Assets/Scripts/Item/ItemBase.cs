using UnityEngine;
using System.Collections;

public class ItemBase : MonoBehaviour {

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
