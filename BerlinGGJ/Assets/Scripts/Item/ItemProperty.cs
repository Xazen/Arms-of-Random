using UnityEngine;
using System.Collections;

public class ItemProperty : MonoBehaviour {

	[SerializeField] private SpriteRenderer slotImage;
	[SerializeField] private int posessionCount = 0;
	public int WeaponType { get; set; }

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
