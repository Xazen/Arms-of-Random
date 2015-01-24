using UnityEngine;
using System.Collections;

public class ItemCollision : MonoBehaviour {

	private ItemBase _itemBase;

	// Use this for initialization
	void Start () {
		_itemBase = GetComponent<ItemBase> ();
	}

}
