using UnityEngine;
using System.Collections;

public class ItemProperty : MonoBehaviour {

	[SerializeField] private SpriteRenderer slotImage;
	[SerializeField] private int posessionCount = 0;

	public void decreasePosessionCount()
	{
		if (posessionCount > 0) 
		{
			posessionCount--;
		}
	}

	public bool canUseItem()
	{
		return (posessionCount > 0);
	}
}
