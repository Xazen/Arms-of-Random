using UnityEngine;
using System.Collections;

public class ItemProperty : MonoBehaviour {

	[SerializeField] private SpriteRenderer slotImage;
	[SerializeField] private int posessionCount = 0;
	[SerializeField] bool selected = false;

	public void decreasePosessionCount(){}
}
