using UnityEngine;
using UnityEngine.UI;

public class ButtonEvents : MonoBehaviour 
{

	public void StartOnClick()
	{

		Application.LoadLevel("Main");
	}

	
	public void QuitOnClick()
	{
		Application.Quit();
	}
}