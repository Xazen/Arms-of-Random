using UnityEngine;
using System.Collections;

public class ItemProperty : MonoBehaviour {

	[SerializeField] private SpriteRenderer slotImage;
	[SerializeField] private int posessionCount = 0;
	[SerializeField] private int initialUses = 2;
	public int WeaponType { get; set; }

	void Start()
	{
		posessionCount = initialUses;
	}

	public void DecreasePosessionCount()
	{
		if (posessionCount > 0) 
		{
			posessionCount--;
		}
	}

	public bool CanUseItem()
	{
		return (posessionCount > 0);
	}
}
