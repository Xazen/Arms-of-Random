using UnityEngine;
using System.Collections;

public class ItemBase : MonoBehaviour {

	private ItemController _itemController;
	public ItemController ItemController
	{
		get
		{
			if(_itemController == null)
			{
				_itemController = GetComponent<ItemController>();
			}
			return _itemController;
		}
	}

	private ItemProperty _itemProperty;
	public ItemProperty ItemProperty
	{
		get 
		{
			if (_itemProperty == null)
			{
				_itemProperty = GetComponent<ItemProperty>();
			}
			return _itemProperty;
		}
	}
		
	private ItemVisual _itemVisual;
	public ItemVisual ItemVisual
	{
		get 
		{
			if (_itemVisual == null)
			{
				_itemVisual = GetComponent<ItemVisual>();
			}
			return _itemVisual;
		}
	}

	private ItemCollision _itemCollision;
	public ItemCollision ItemCollision
	{
		get
		{
			if (_itemCollision == null)
			{
				_itemCollision = GetComponent<ItemCollision>();
			}
			return _itemCollision;
		}
	}
}
