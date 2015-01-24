using UnityEngine;
using System.Collections;

public class PlayerInventory : MonoBehaviour {

	private PlayerBase _playerBase;
	[SerializeField] private GameObject[] itemList;

	// Use this for initialization
	void Start () {
		_playerBase = GetComponent<PlayerBase> ();
		_playerBase.PlayerInput.number += ItemSelectedWithIndex;
	}

	public void ItemSelectedWithIndex(int index)
	{
		Debug.Log ("Item selected: " + index);
	}
}
